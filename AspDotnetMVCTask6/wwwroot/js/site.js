// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Flowers click event.
$(".div-flower-items input[type=radio]").click(function () {
    $('#imgFlowerPreview').attr('src', '');
    $('#spanFlowerName').text('');
});
$("#btnFlowerPreview").click(function () {
    let selectedId = $(".div-flower-items input[type=radio]:checked").attr('id');
    let imgSrc = $("#hdn_" + selectedId).val();
    let flowerName = $("#lbl_" + selectedId).text();
    $('#imgFlowerPreview').attr('src', imgSrc);
    $('#spanFlowerName').text(flowerName);
});
