(function () {
    'use strict';

    angular
        .module('app')
        .controller('largeReport', largeReport);

    largeReport.$inject = ['$http'];

    function largeReport($http) {
        var vm = this;
        vm.title = 'largeReport';

        activate();

        function activate() {
            $http({ method: "GET", url: "/api/largeReport"}).
                   then(function (response) {
                       vm.data = response.data;
                   });
        }
    }
})();
