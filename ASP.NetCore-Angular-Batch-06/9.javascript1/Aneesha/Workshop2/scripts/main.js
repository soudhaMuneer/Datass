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

function loginCheck()
{
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    event.preventDefault();
    

    if(password.length<8 && password.length>0){
        alert("password must be 8 characters or more");
        return false;
    }
     
     if(email == "lessile@gmail.com")
     
    {
        window.location = "./profile.html";
        
        return true;
    }
    else{
        alert("invalid email");
        return false;
    }

    

}

