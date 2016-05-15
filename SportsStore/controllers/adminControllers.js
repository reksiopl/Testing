/// <reference path="../angular.js" />

angular.module("sportsStoreAdmin")
    .constant("authUrl", "http://localhost:50157/api/users/login")
    .controller("authCtrl", function ($scope, $http, $httpParamSerializerJQLike, $location, authUrl) {
        $scope.authenticate = function (username, password) {
            $http.post()
            
        }
    })
