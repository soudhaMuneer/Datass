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

    else if(buttonVal=="myButton3")
    {

        var id=document.getElementById('aboutTextBox');
        var aboutButton=getElementById('aboutButton');
        id.style.display='block';
        aboutButton.style.display='block';

    }
    else if(buttonVal=="myButton4")
    {

        var id=document.getElementById('experinceTextBox');
        var aboutButton=getElementById('experinceButton');
        id.style.display='block';
        aboutButton.style.display='block';

    }


    
}

function add(text)
{
    if(text == "skill")
    {
    var data=document.getElementById('myTextBox').value;
    var textBox=document.getElementById('myTextBox');
    var listId=document.getElementById('skillList');
    var skills=[]
    skills.push(data);
    console.log(skills);
    for(i=0;i<skills.length;i++)
    {
        var li = document.createElement('li');
            li.textContent = skills[i];
             listId.appendChild(li);
             textBox.value='';

    }
}

else if(text =="edu")
{
    var data=document.getElementById('eduTextBox').value;
    var textBox=document.getElementById('eduTextBox');
    var listId=document.getElementById('eduList');
    var edu=[]
    edu.push(data);
    console.log(edu);
    for(i=0;i<edu.length;i++)
    {
        var li = document.createElement('li');
            li.textContent = edu[i];
             listId.appendChild(li);
             textBox.value='';
    }
}

else if(text =="abtt"){
  var data=document.getElementById('aboutTextBox').value;
  var textBox=document.getElementById('aboutTextBox');
  var listId=document.getElementById('abt');
  var abtt=[]
  abtt.push(data);
  console.log(abtt);
  for(i=0;i<abtt.length;i++)
  {
    var li = document.createElement('li');
    li.textContent = abtt[i];
    listId.appendChild(li);
    textBox.value='';
  }
}
else if(text =="abtt"){
    var data=document.getElementById('aboutTextBox').value;
    var textBox=document.getElementById('aboutTextBox');
    var listId=document.getElementById('abt');
    var abtt=[]
    abtt.push(data);
    console.log(abtt);
    for(i=0;i<abtt.length;i++)
    {
      var li = document.createElement('li');
      li.textContent = abtt[i];
      listId.appendChild(li);
      textBox.value='';
    }
}
}