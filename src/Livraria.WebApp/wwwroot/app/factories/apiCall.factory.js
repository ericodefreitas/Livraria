(function () {
    'use strict';

    angular
        .module('app')
        .factory('apiCall', api);

    api.$inject = ['$q', '$http', 'constants'];

    function api($q, $http, constants) {
        var service = {
            'getLivros': getLivros,
            'getLivro': getLivro,
            'getLivrosOrdenadosPorNome': getLivrosOrdenadosPorNome,
            'putLivro': putLivro,
            'postLivro': postLivro,
            'deleteLivro': deleteLivro
        };
        return service;

        function getLivros() {
            //Call API
            return callApi('data');
        }
        
        function getLivro(id) {
            //Call API
            return callApi('data/' + id);
        }

        function getLivrosOrdenadosPorNome(id) {
            //Call API
            return callApi('data/OrdenarPorNome/' + id);
        }
        
        function putLivro(data, id) {
            //Call API
            return callApi('data/' + id, 'PUT', data);
        }

        function postLivro(data) {
            //Call API
            return callApi('data', 'POST', data);
        }

        function deleteLivro(id) {
            return callApi('data/' + id, 'DELETE')
        }
        
        var callApi = callApi;

        function callApi(action, method, data) {
            //Defer promess
            var q = $q.defer();

            //Start data (if need)
            if (!data)
                data = {};

            //Set method
            if (!method)
                method = 'GET';

            var headers = {};
            headers['Content-Type'] = 'application/json';

            //Send data to api
            $http({
                url: constants.url + action,
                headers: headers,
                method: method,
                data: angular.toJson(data)
            })
                .then(function (retorno) {
                    q.resolve(retorno.data);
                }, function (error) {
                    console.error(error);
                    if (error.status == 401) {
                    }

                    q.reject(error);
                });
            //return promise
            return q.promise;

        };
    }
})();