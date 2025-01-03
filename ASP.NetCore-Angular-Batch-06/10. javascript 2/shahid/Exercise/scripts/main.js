// var applicantList = [
//     { name: "Alex", image: "images/m1.png",  experience: "2 years" },
//     { name: "Ameya", image: "./images/m2.png",  experience: "2 years" },
//     { name: "Ommer", image: "./images/m1.png", experience: "4 years" },
// ];
// listApplicants();
// function listApplicants() {
//     var contentDiv = document.getElementById('card');
//     var content = document.getElementById('content');
   
//    for(let value in applicantList) {

//         //creating div for each item in the array
//         var cardDiv = document.createElement('p');
//         var image = document.createElement('img');
//         image.src = applicantList[value].image;
//         var name=document.createElement('b');
//         name.textContent = applicantList[value].name;
//         var experience=document.createElement('p');
//         experience.textContent=applicantList[value].experience;
//         // console.log(item.image);
//         cardDiv.appendChild(image);
//         cardDiv.appendChild(name);
//         cardDiv.appendChild(experience);
//         contentDiv.appendChild(cardDiv);
   
//    }
    
// }

// var table = document.getElementById('card');
// function myFunction() {
//     var table = document.getElementById("myTable");
//     var row = table.insertRow(0);
//     var row1 = table.insertRow(1);
//     var cell1 = row.insertCell(0);
//     var cell2 = row1.insertCell(0);
//     cell1.innerHTML = "NEW CELL1";
//     cell2.innerHTML = "NEW CELL2";
//   }

var jobs = [
    {name:"Social media 1",image:"Exercise/images/m1.png",location:"online",date:"16-06-23",time:"10am"},
    {name:"Social media 2",image:"Exercise/images/m1.png",location:"online",date:"16-06-23",time:"10am"},
    {name:"Social media 3",image:"Exercise/images/m1.png",location:"online",date:"16-06-23",time:"10am"},
    {name:"Social media 4",image:"Exercise/images/m1.png",location:"online",date:"16-06-23",time:"10am"},
];

for(let j in jobs){

    var r1 = document.createElement("TR");
r1.setAttribute("id","tr1");
document.getElementById("table").appendChild(r1);
// for(let j in jobs){
var c1 = document.createElement("TD");
var t = document.createTextNode(jobs[j].name);
c1.appendChild(t);
document.getElementById("tr1").appendChild(c1);

// }
}





// var x = document.createElement("TR");
// x.setAttribute("id", "myTr");
// document.getElementById("table").appendChild(x);

// var y = document.createElement("TD");
// var t = document.createTextNode("new cell");
// y.appendChild(t);
// document.getElementById("myTr").appendChild(y);
