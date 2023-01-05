// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Store items click event //
$(".tbl-body-items tr").click(function () {
    var imgSrc = $(this).children('td').children('img').attr('src');
    var itemName = $(this).children('#tdItemName').text();
    var priceval = $(this).children('td').children('span').children('#item_Cost').val();
    $('#imgItemPreview').attr('src', imgSrc);
    $('#spanItemName').text(itemName);
    $('#spanItemTotal').text(": " + priceval);
});