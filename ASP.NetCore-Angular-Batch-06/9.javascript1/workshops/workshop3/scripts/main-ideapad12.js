function validateForm()
{
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var role=document.getElementById("role").value;
    var location=document.getElementById("location").value; 
    var website=document.getElementById("website").value;
     if(name==null  || name=="" )
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

function validateMail()
{
    var email=document.getElementById("email").value;
    const pattern= /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
   if(!pattern.test(email))
   {
        alert("Please enter valid mail");
        return false;
   }
   else
    {
        return true;
    }
}


function validatephone()
{
    var phone=document.getElementById("phone").value;
    const pattern= /^([0|\+[0-9]{1,5})?([7-9][0-9]{9})$/;
   if(!pattern.test(phone))
   {
        alert("Please enter valid phone number");
        return false;
   }
   else
    {
        return true;
    }
}

