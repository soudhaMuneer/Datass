<<<<<<< HEAD
function visible() {
    var z = document.getElementById("blur");
    z.classList.add("blur1")

    var x = document.getElementById("t5");
    x.style.visibility = "visible";
    x.style.transform = "scale(1)";

    const txt1 = document.getElementById("fullname").value;
    const txt2 = document.getElementById("username").value;
    const txt3 = document.getElementById("email").value;
    const txt4 = document.getElementById("phone").value;
    document.getElementById("output").innerHTML = "Entered Details are : " + "</br>" + "<h2>" + txt1 + "</h2>" + "</br>" + "UserName : " + txt2 + "</br>" + "Email : " + txt3 + "</br>" + "Phone : " + txt4;
}

function cancel() {

    var y = document.getElementById("t5");
    y.style.visibility = "hidden";
    var z = document.getElementById("blur");
    z.classList.remove("blur1")
=======
function visible() {
    var z = document.getElementById("blur");
    z.classList.add("blur1")

    var x = document.getElementById("t5");
    x.style.visibility = "visible";
    x.style.transform = "scale(1)";

    const txt1 = document.getElementById("fullname").value;
    const txt2 = document.getElementById("username").value;
    const txt3 = document.getElementById("email").value;
    const txt4 = document.getElementById("phone").value;
    document.getElementById("output").innerHTML = "Entered Details are : " + "</br>" + "<h2>" + txt1 + "</h2>" + "</br>" + "UserName : " + txt2 + "</br>" + "Email : " + txt3 + "</br>" + "Phone : " + txt4;
}

function cancel() {

    var y = document.getElementById("t5");
    y.style.visibility = "hidden";
    var z = document.getElementById("blur");
    z.classList.remove("blur1")
>>>>>>> a06a0ef73be60bc575a99990d3b212d1bc8ee36f
} 