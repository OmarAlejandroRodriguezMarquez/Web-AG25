function suma(){
let numA = document.getElementById("numA").value;
let numB = document.getElementById("numB").value;

let suma = parseInt(numA) + parseInt(numB);
document.getElementById("resultado").value = suma;
window.location.href = "html/dos.html";
}

function resta(){
let numA = document.getElementById("numA").value;
let numB = document.getElementById("numB").value;

let suma = parseInt(numA) - parseInt(numB);
alert(suma);
}