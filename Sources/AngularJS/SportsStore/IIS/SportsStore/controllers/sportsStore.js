/// <reference path="../angular.js" />

angular.module("sportsStore")
.constant("dataUrl", "http://localhost:50157/api/product/getallproducts")
.constant("orderUrl", "http://localhost:50157/api/order/sendorder")
.controller("sportsStoreCtrl", function ($scope, $http, $httpParamSerializerJQLike, $location,
    dataUrl, orderUrl, cart) {

    $scope.data = {};

    
    $http.get(dataUrl).
          success(function (data, status, headers, config) {
              $scope.data.products = data;

          }).
          error(function (data, status, headers, config) {
              $scope.data.error = data;
          });

    $scope.sendOrder = function (shippingDetails) {
        var order = angular.copy(shippingDetails);
        order.products = cart.getProducts();
        $http({
            method: 'POST',
            url: orderUrl,
            data: $httpParamSerializerJQLike(order),
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded'
            }
        }).success(function (data) {
            $scope.data.orderId = data.id;
            cart.getProducts().length = 0;
        })
        .error(function (error) {
                $scope.data.orderError = error;
        }).finally(function() {
            $location.path("/complete");
        });


    };
});