var app = angular.module('MyApp', []);

app.controller("AccountController", function ($scope, $http) {
    
    debugger;

    $scope.btntext = "Login";
    $scope.login = function () {
        $scope.btntext = "Please wait..!";
        $http({
            method: "POST",
            url: '/Account/userlogin',
            data: $scope.user
        }).success(function (d) {
            $scope.btntext = 'Login';
            if (d == 1) {
                window.location.href = '/Home/About';
            }
            else {
                alert(d);
            }
            $scope.user = null;
        }).error(function () {
            alert('failed');
        })
    }

})