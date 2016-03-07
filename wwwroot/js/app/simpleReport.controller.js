(function () {
    'use strict';

    angular
        .module('app')
        .controller('simpleReport', simpleReport);

    simpleReport.$inject = ['$http'];

    function simpleReport($http) {
        var vm = this;
        vm.title = 'simpleReport';
        vm.pdf = pdf;

        activate();

        function activate() {
            $http({ method: "GET", url: "/api/SimpleReport"}).
                   then(function (response) {
                       vm.data = response.data;
                   });
        }

        function pdf() {
            var doc = new jsPDF();
            
            var source = $('#simpleReport')[0];

            pdf.fromHTML(source);

            doc.save('Test.pdf');
        }
    }
})();
