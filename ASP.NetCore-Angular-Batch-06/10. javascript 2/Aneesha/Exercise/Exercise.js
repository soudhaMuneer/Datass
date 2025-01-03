const JobList = [
       {image:"https://cdn-icons-png.flaticon.com/128/731/731985.png",name:"Social Media Assistant",Location:"online",Date:"16-06-23",Time:"10.am"},
       {image:"https://cdn-icons-png.flaticon.com/128/731/731985.png",name:"Social Media Assistant",Location:"online",Date:"16-06-23",Time:"10.am"},
       {image:"https://cdn-icons-png.flaticon.com/128/731/731985.png",name:"Social Media Assistant",Location:"online",Date:"16-06-23",Time:"10.am"}
    ];
              
    function TableContent(){

    const DivTable = document.getElementById("Div-Table");
    let table = document.createElement("table");
    let tbody = document.createElement("tBody");


    for( let i=0; i<=JobList.length; i++){
         let row = document.createElement('tr');

         for(let key in JobList[i]){
          let column = document.createElement('td');
          
           
          if(key === 'image'){
            let image = document.createElement('img');
            image.src = JobList[i][key];
            image.width = "30";
            image.height = "30";
            column.appendChild(image);
            
          } else {
            column.textContent = JobList[i][key];
          }
          row.appendChild(column);
         }
         tbody.appendChild(row);

    }
    table.appendChild(tbody)
    DivTable.appendChild(table);
   }
   TableContent();