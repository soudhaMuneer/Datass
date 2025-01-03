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
        alert(description+"Please enter your job description");
        return false;

    }
    if(salary==null || salary=="")
    {
        alert(salary+"Please enter your salary");
        return false;

    }
    if(location==null ||location=="")
    {
        alert(location+"Please enter your location");
        return false;

    }
    

}

function validateCharacter(inputChar)
{
   
    const regex = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(inputChar))
    {
        alert("Allowed alphabets only")
        return false;
    }

}
function validateCharacter1(inputChar1)
{
    const tmt = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
    if(!tmt.test(inputChar1))
    {
        alert("Allowed alphabets only 1")
        return false;
    }
}
function validateCharacter2(inputChar2)
{
    const smt = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
    if(!smt.test(inputChar2))
    {
        alert("Allowed alphabets only 2")
        return false;
    }
}
function validateCharacter3(inputChar3)
{
    const rmt = /[0-9]/; // regular expression pattern for alphabetical characters
    if(!rmt.test(inputChar3))
    {
        alert("Allowed numbers only")
        return false;
    }
}
