angular.module("livraria").factory("livrariaAPI", function ($http, config) {
    var _getLivros = function () {
        return $http.get(config.baseUrl + "OrdenarPorNome")
    };

    var _getLivro = function (id) {
        return $http.get(config.baseUrl + id)
    };

    var _postLivro = function (data) {
        return $http.post(config.baseUrl, data)
    };

    var _putLivro = function (id, data) {
        return $http.put(config.baseUrl + id, data)
    };

    var _deleteLivro = function (id) {
        return $http.delete(config.baseUrl + id)
    };

    return {
        getLivros: _getLivros,
        getLivro: _getLivro,
        postLivro: _postLivro,
        putLivro: _putLivro,
        deleteLivro: _deleteLivro
    };
});