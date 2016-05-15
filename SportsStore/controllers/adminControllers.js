/// <reference path="../angular.js" />

angular.module("sportsStoreAdmin")
    .constant("authUrl", "http://localhost:50157/api/users/login")
    .controller("authCtrl", function ($scope, $http, $httpParamSerializerJQLike, $location, authUrl) {
        $scope.authenticate = function (username, password) {
            $http({
                method: 'POST',
                url: authUrl,
                data: $httpParamSerializerJQLike({
                    username: username,
                    password: password
                }),
                withCredentials: true,
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded'
                }
            }).success(function (data) {
                $location.path("/main");
            }).error(function (error) {
                $scope.authenctionError = error;
            });
        };
    })
