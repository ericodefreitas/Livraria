
angular.module("livraria").controller("livrariaCtrl", function ($scope, $filter, livrariaAPI) {
    $scope.app = "Lista de Livros";
    $scope.livros = [];

    var getLivros = function () {

        livrariaAPI.getLivros().then(function (data, status) {
            $scope.livros = data.data;
        });
    };

    var getLivro = function (id) {

        livrariaAPI.getLivro(id).then(function (data) {

            $scope.livro = data.data;
        });
    };

    var postLivro = function (data) {

        livrariaAPI.postLivro(data).then(function () {
            getLivros();
        });
    };

    var putLivro = function (id, data) {

        livrariaAPI.putLivro(id, data).then(function (data) {
            getLivros();
        });
    };

    var deleteLivro = function (id) {

        if ($scope.livro && $scope.livro.id == id)
            delete $scope.livro;

        livrariaAPI.deleteLivro(id).then(function (data) {
            getLivros();
        });
    };

    $scope.alterarLivro = function (id) {
        getLivro(id);
    };

    $scope.apagarContatos = function (contatos) {
        $scope.contatos = contatos.filter(function (contato) {
            if (!contato.selecionado) return contato;
        });
    };

    $scope.adicionarlivro = function (livro) {

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