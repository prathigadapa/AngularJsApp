/// <reference path="angular.min.js" />


var app = angular.module("Demo", ["ngRoute"])
    //$routeProvider used to configure routes
.config(function ($routeProvider,$locationProvider) {
    $routeProvider.when("/home",
        {
            templateUrl: "Templates/Home.html",
            controller:"homeController"
        })
    .when("/students",
        {
            templateUrl: "Templates/students.html",
            controller: "studentsController"
        })
    .when("/courses",
        {
            templateUrl: "Templates/coursess.html",
            controller: "coursesController"
        })

    $locationProvider.html5Mode(true);
}).controller("homeController", function ($scope) {
    $scope.Message = "Home Page";

}).controller("coursesController", function ($scope) {
    $scope.courses = ["C#", "VB.Net", "SQL server"];

})
    //.controller("studentsController", function ($scope,$http) {
    //    $http.get("TestWebService.asmx/GetStudents", [])
    //        .then(function(response) {
    //            $scope.students =response.data;
    //    })
 

