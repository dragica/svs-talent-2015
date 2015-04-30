$(document).ready(function () {
    $.ajax({
        url: 'http://localhost:61322/home/getsearchresult',
        type: 'POST',        
        dataType: 'json',
        cache: false,
        success: function (data) {
            drawTable(data);
            debugger;
        }        
    });
});

function drawTable(data) {
    for (var i = 0; i < data.length; i++) {
        drawRow(data[i]);
    }
}

function drawRow(rowData) {
    var row = $("<tr />")
    $("#bikes").append(row); 
    row.append($("<td>" + rowData.RegNumber + "</td>"));
    row.append($("<td>" + rowData.Producer + "</td>"));
    row.append($("<td>" + rowData.Model + "</td>"));
    row.append($("<td>" + rowData.Colour + "</td>"));
}