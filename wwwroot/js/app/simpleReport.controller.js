﻿(function () {
    'use strict';

    angular
        .module('app')
        .controller('simpleReport', simpleReport);

    simpleReport.$inject = ['$http'];

    function simpleReport($http) {
        var vm = this;
        vm.title = 'simpleReport';

        activate();

        function activate() {
            $http({ method: "GET", url: "/api/SimpleReport"}).
                   then(function (response) {
                       vm.data = response.data;
                   });
        }
    }
})();
