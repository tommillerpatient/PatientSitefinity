﻿angular.module('signInApp', [])
    .controller('signInCtrl', ['$scope', '$http', function ($scope, $http) {

    $scope.person = {};

    $scope.login = function () {

        //alert(JSON.stringify($scope.person));

        //if ($scope.signUpForm.$invalid) {
        //    $scope.signUpForm.$setDirty();
        //    return;
        //}

        var req = {
            method: 'POST',
            headers: {
                "Accept": "application/json",
                "Content-Type": "application/json"
            },
            data: $scope.person
        };

        req.url = '/api/account';
        $scope.submitting = true;
        $http(req).then(function (res) {

            $scope.submitting = false;
            //alert(JSON.stringify(res));
            location.reload(true);

        }, function (e) {
            $scope.submitting = false;
            console.log(e);
        });

    }

}]);