// function loginCheck(){
//     var email= document.getElementById("email").value;
//     var password=document.getElementById("password").value;
//     if(email==null || email=="" ){
//         alert("***email cannot be empty***")
//         return false;

//     }
//     if(password==null || password=="" ){
//         alert("***password cannot be empty***")
//         return false;

//     }else
//     {
//         return true;
//     }

// }

function validateLogin(){
    
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    var test = false;
    if(email==null || email=="" ){
        var x= document.getElementById("error");
        x.style.visibility="visible";
        test = false;
        document.getElementById("error").style.color="red";
       
    }
    else{
        
        test= true;
    }
    if(password==null || password=="" ){
        
        var p= document.getElementById("error2");
        p.style.visibility="visible";
        test= false;
        document.getElementById("error2").style.color="red";

    }
    else
    {
        test= true;
        
    }
    
    return test;
    
    
}
function check(){
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    var test = false;
    var pattern=/^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/; 
    var code=/^[a-zA-Z0-9!@#$%^&*]{8,32}$/;
    if(!pattern.test(email)){
        var x= document.getElementById("error2");
        x.style.visibility="visible";
        document.getElementById("error").innerHTML="***Invalid mail***";
        
        document.getElementById("error").style.color="red";
        return false;
    }
    else{
        ;
        test= true;
    }
    if(!code.test(password) ){
        var p= document.getElementById("error2");
        p.style.visibility="visible";
        
        document.getElementById("error2").innerHTML="***Enter strong password***";
        document.getElementById("error2").style.color="red";
        return false;
    }
    else
    {
        document.getElementById("error").innerHTML=""
        
        document.getElementById("error2").innerHTML="";
        
        return true;
        
    }
    
   
    
}
function mail(){
    document.getElementById("email").value;
    document.getElementById("email").style.top="155px"
}
function passWord(){
   
    document.getElementById("password").style.top="231px";
    document.getElementById("img").style.top="233px";

}