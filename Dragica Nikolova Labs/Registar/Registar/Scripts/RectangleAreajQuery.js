$(document).ready(function () {
    $('#btnCalculate').click(function () {

        var total = $("#txt1").val() * $("#txt2").val();
        
        $('#result2').val(total);

        alert("With jQuery: " + total);
        
    });
});