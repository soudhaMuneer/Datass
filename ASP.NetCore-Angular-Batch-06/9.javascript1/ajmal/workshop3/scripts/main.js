function validateForm()
{
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var role=document.getElementById("role").value;
    var location=document.getElementById("location").value; 
    var website=document.getElementById("website").value;
     if(name==null  || name=="")
    {
        alert("Please Enter Name");
        return false;
    }
  
    if(email==null || email=="")
    {
        alert("Please Enter Email");
        return false;
    }
    if(phone==null  || phone=="")
    {
        alert("Please Enter Phone Number");
        return false;
    }
    if(role=="" || role==null)
    {
        alert("Please Enter Role");
        return false;
    }
    if(location==null || location=="")
    {
        alert("Please Enter Location");
        return false;
    }
    if(website==null || website=="")
    {
        alert("Please Enter Website");
        return false;
   
    }
    return true;
} 

function validateName()
{
    var website=document.getElementById("name").value;
    const code=  /^([A-Za-z])/; 
   if(!code.test(website)){
       alert("invalid name");
       return false;
   }
   else{
   return true;
   }
}

function validateMail()
{
    var email=document.getElementById("email").value;
    const pattern=  /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/; 
   if(!pattern.test(email)){
       alert("invalid email");
       return false;
   }
   else{
   return true;
   }
}
function validatePhone()
{
    var phone=document.getElementById("phone").value;
    const number= /^[0-9]{10}$/; 
   if(!number.test(phone)){
       alert("invalid phone number");
       return false;
   }
   else{
   return true;
   }
}
function validateRole()
{
    var website=document.getElementById("role").value;
    const code=  /^([A-Za-z])/; 
   if(!code.test(website)){
       alert("invalid role");
       return false;
   }
   else{
   return true;
   }
}
function validateLocation()
{
    var website=document.getElementById("location").value;
    const code=  /^([A-Za-z])/; 
   if(!code.test(website)){
       alert("invalid location");
       return false;
   }
   else{
   return true;
   }
}
function validateWebsite()
{
    var website=document.getElementById("website").value;
    const code= /^(https?|ftp):\/\/(([a-z\d]([a-z\d-]*[a-z\d])?\.)+[a-z]{2,}|localhost)(\/[-a-z\d%_.~+]*)*(\?[;&a-z\d%_.~+=-]*)?(\#[-a-z\d_]*)?$/i; 
   if(!code.test(website)){
       alert("invalid url");
       return false;
   }
   else{
   return true;
   }
}

