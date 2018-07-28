(function () {
    'use strict';

    angular
        .module('app')
        .controller('index', index);

    index.$inject = ['$location'];

    function index($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'index';

        activate();
    }
})();
