function validateUser()
{
    
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    if(email=="" ||  email==null)
    {
        alert("Please Enter Your Email ");
        return false;
    }
<<<<<<< HEAD
    if(password=="" ||  password==null)
=======
    else if(password=="" ||  password==null)
>>>>>>> b16ec8a48574d01233b4dfcbbe35809c6b7740cc
    {
        alert("Please Enter Your Password ");
        return false;
    }
<<<<<<< HEAD
=======
    else if(password.length<8 && password.length>0)
    {
        alert("password must contain 8 characters");
        return false;
    }
    
>>>>>>> b16ec8a48574d01233b4dfcbbe35809c6b7740cc
  

}

function loginCheck()
{
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    event.preventDefault();
    
<<<<<<< HEAD
    
    if(email== "lessile@gmail.com" && password=="1234")
=======
    if(email== "lessile@gmail.com" && password.length>=8 && password=="12345678")
>>>>>>> b16ec8a48574d01233b4dfcbbe35809c6b7740cc
    {
        window.location = "./profile.html";
        
        return true;
    }
    else{
        alert("invalid email or password");
        return false;
    }
}

