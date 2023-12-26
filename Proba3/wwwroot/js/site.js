// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#database").hover(function () { $("#submenu1").show("slow"), $("#submenu2, #submenu3, #submenu5").hide('slow') });
    $("#submenu1").mouseleave(function () { $("#submenu1").hide('slow') });
    $("#reports").hover(function () { $("#submenu2").show("slow"), $("#submenu1, #submenu3, #submenu5").hide('slow') });
    $("#submenu2").mouseleave(function () { $("#submenu2").hide('slow') });
    $("#system").hover(function () { $("#submenu3").show("slow"), $("#submenu1, #submenu2, #submenu5").hide('slow') });
    $("#submenu3").mouseleave(function () { $("#submenu3").hide('slow') });
    $("#author").hover(function () { $("#submenu5").show("slow"), $("#submenu1, #submenu2, #submenu3").hide('slow') });
});