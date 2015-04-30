function getResult() {
    var a = parseInt(document.getElementById("txt1").value, 10);
    var b = parseInt(document.getElementById("txt2").value, 10);
    var res = a * b;
    document.getElementById("result").innerHTML += String(res);
}

