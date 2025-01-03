<<<<<<< HEAD
function validateUser()
{
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    if(email=="" ||  email==null)
    {
        alert("Please Enter Your Email ");
        return false;
    }
    if(password=="" ||  password==null)
    {
        alert("Please Enter Your Password ");
        return false;
    }
}

function mail()
{
    var email=document.getElementById("email").value;
    var structure=/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    if(! structure.test (email))
    {
        alert("Enter Valid Email");
        return false;
    }
    else{
        return true;    
    }
}


function pass()
{
    var pass=document.getElementById("password").value;
    var structure=/^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/;
    if(! structure.test (pass))
    {
        alert("Enter Valid password");
        return false;
    }
    else{
        return true;    
    }
}


function loginCheck()
{
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    event.preventDefault();
    if(email== "hruthu@gmail.com" && password=="1234"){
        window.location = "./profile.html";   
        return true;
    }
    else{
        alert("invalid email or password");
        return false;
    }
}
=======
function validateUser()
{
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    if(email=="" ||  email==null)
    {
        alert("Please Enter Your Email ");
        return false;
    }
    if(password=="" ||  password==null)
    {
        alert("Please Enter Your Password ");
        return false;
    }
}

function mail()
{
    var email=document.getElementById("email").value;
    var structure=/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    if(! structure.test (email))
    {
        alert("Enter Valid Email");
        return false;
    }
    else{
        return true;    
    }
}


function pass()
{
    var pass=document.getElementById("password").value;
    var structure=/^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/;
    if(! structure.test (pass))
    {
        alert("Enter Valid password");
        return false;
    }
    else{
        return true;    
    }
}


function loginCheck()
{
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    event.preventDefault();
    if(email== "hruthu@gmail.com" && password=="1234"){
        window.location = "./profile.html";   
        return true;
    }
    else{
        alert("invalid email or password");
        return false;
    }
}
>>>>>>> a06a0ef73be60bc575a99990d3b212d1bc8ee36f
