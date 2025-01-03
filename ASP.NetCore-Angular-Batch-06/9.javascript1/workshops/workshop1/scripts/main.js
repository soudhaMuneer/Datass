function validateForm()
{
    
    var jobTitle=document.myForm.jobTitle.value;  
    var description=document.myForm.jobDescription.value;  
    var salary=document.myForm.salary.value; 
    var location=document.myForm.location.value; 

    if(jobTitle==null || jobTitle=="")
    {
        alert(jobTitle+"Please enter your job title");
        return false;
    }
     if(description==null || description=="")
    {
<<<<<<< HEAD
        alert("Please enter your job description");
=======
        alert(description+"Please enter your job description");
>>>>>>> b16ec8a48574d01233b4dfcbbe35809c6b7740cc
        return false;

    }
    if(salary==null || salary=="")
    {
<<<<<<< HEAD
        alert("Please enter your salary");
=======
        alert(salary+"Please enter your salary");
>>>>>>> b16ec8a48574d01233b4dfcbbe35809c6b7740cc
        return false;

    }
    if(location==null ||location=="")
    {
<<<<<<< HEAD
        alert("Please enter your location");
=======
        alert(location+"Please enter your location");
>>>>>>> b16ec8a48574d01233b4dfcbbe35809c6b7740cc
        return false;

    }
    

}

function validateCharacter(inputChar)
{
   
    const regex = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(inputChar))
    {
        alert("Allowed alphabets")
        return false;
    }

<<<<<<< HEAD
}

=======
>>>>>>> b16ec8a48574d01233b4dfcbbe35809c6b7740cc
