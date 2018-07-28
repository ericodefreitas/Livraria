
angular.module("livraria").controller("livrariaCtrl", function ($scope, livrariaAPI) {
    $scope.app = "Lista de Livros";
    $scope.livros = [];
    $scope.idiomas = [
        { descricao: "Português", id: 0 },
        { descricao: "Inglês", id: 1 },
        { descricao: "Espanhol", id: 2 },
        { descricao: "Alemão", id: 3 },
        { descricao: "Francês", id: 4 }
    ];

    var getLivros = function () {

        livrariaAPI.getLivros().then(function (data, status) {
            $scope.livros = data.data;
        });
    }

    var getLivro = function (id) {

        livrariaAPI.getLivro(id).then(function (data) {

            $scope.livro = data.data;
        });
    }

    var postLivro = function (data) {

        livrariaAPI.postLivro(data).then(function () {
            getLivros();
        });
    }

    var putLivro = function (id, data) {

        livrariaAPI.putLivro(id, data).then(function (data) {
            getLivros();
        });
    }

    var deleteLivro = function (id) {

        livrariaAPI.deleteLivro(id).then(function (data) {
            getLivros();
        });
    }

    $scope.alterarLivro = function (id) {
        getLivro(id);
    };

    $scope.adicionarlivro = function (livro) {

        $scope.livro.idioma = $scope.livro.idioma.id;

        if (!$scope.livro.id)
            postLivro($scope.livro);
        else
            putLivro($scope.livro.id, $scope.livro);

        delete $scope.livro;
    };

    $scope.apagarlivro = function (id) {
        deleteLivro(id);
    };

    getLivros();
});