function showForm(buttonVal)
{
    var id=document.getElementById('myTextBox');
    
    var skillButton=document.getElementById('myButton');


    if(buttonVal=="myButton1")
    {
    id.style.display='block';
    skillButton.style.display='block';
    }

    else if(buttonVal=="myButton2")
    {

        var id=document.getElementById('eduTextBox');
        var eduButton=document.getElementById('eduButton');
        id.style.display='block';
        eduButton.style.display='block';
    }
    else if(buttonVal=="myButton3"){
        var id=document.getElementById('edappalTextBox');
        var edappalButton=document.getElementById('edappalButton');
        id.style.display='block';
        edappalButton.style.display='block';
    }
    else if(buttonVal=="myButton4"){
        var id=document.getElementById('pattambiTextBox');
        var pattambiButton=document.getElementById('pattambiButton');
        id.style.display='block';
        pattambiButton.style.display='block';
    }


    
}

function add(text)
{
    if(text=="skill")
    {
    var data=document.getElementById('myTextBox').value;
    var textBox=document.getElementById('myTextBox');
    var listId=document.getElementById('skillList');
    var skills=[]
    skills.push(data);
    console.log(skills);
    for(i=0;i<skills.length;i++)
    {
        // Create a new list item
        var li = document.createElement('li');

         // Set the text content of the list item
            li.textContent = skills[i];

             // Append the list item to the list element
             listId.appendChild(li);
             textBox.value='';

    }
}

 else if(text=="edu")
 {

     var data=document.getElementById('eduTextBox').value;
     var textBox=document.getElementById('eduTextBox');
     var listId=document.getElementById('eduList');
     var edu=[]
     edu.push(data);
    
    console.log(edu);
    var br=document.createElement("br")
    listId.appendChild(br);
    for(i=0;i<edu.length;i++)
     {
        // Create a new list item
         var li = document.createElement('li');

          // Set the text content of the list item
            li.textContent = edu[i];

              // Append the list item to the list element
              listId.appendChild(li);
             textBox.value='';

     }
 }
 else if(text=="edappal"){
    var data=document.getElementById('edappalTextBox').value;
    var textBox=document.getElementById('edappalTextBox');
    var listId=document.getElementById('about');
   var edappal=[] 
   edappal.push(data);
   
   console.log(edappal);
   for(i=0;i<edappal.length;i++)
   {
      // Create a new list item
       var li = document.createElement('p');

        // Set the text content of the list item
          li.textContent = edappal[i];

            // Append the list item to the list element
            listId.appendChild(li);
           textBox.value='';

   }
  
 }
 else if(text=="pattambi"){
    var data=document.getElementById('pattambiTextBox').value;
    var textBox=document.getElementById('pattambiTextBox');
    var listId=document.getElementById('iloveyou');
   var pattambi=[] 
   pattambi.push(data);
   console.log(pattambi);
   var br =document.createElement('br');
   listId.appendChild(br);
   for(i=0;i<pattambi.length;i++)
   {
      // Create a new list item
       var li = document.createElement('li');

        // Set the text content of the list item
          li.textContent = pattambi[i];


            // Append the list item to the list element
            listId.appendChild(li);
           textBox.value='';

   }
}
}

