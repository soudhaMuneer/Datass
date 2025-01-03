import { Component } from '@angular/core';

@Component({
  selector: 'app-courcecomponent',
  templateUrl: './courcecomponent.component.html',
  styleUrls: ['./courcecomponent.component.css']
})
export class CourcecomponentComponent {
    cource =[
      {
         name:"bsc",
         duration:"3 years",
         type:"all"
    },
      {
         name:"bca",
         duration:"2 years",
         type:"free"
    },
      {
         name:"b.com",
         duration:"3 years",
         type:"paid"
    },
      {
         name:"food technology",
         duration:"3 years",
         type:"paid"
    },
      {
         name:"finance",
         duration:"5 years",
         type:"free"
    }
  ]
  
arraycall(){ 
  return this.all=this.cource.length;
}
 
arrayname(){
 return this.cource.map( arname=>arname.name );
}
arrayduration(){
  return this.cource.map(arraydur=>arraydur.duration);
}
all:number =2;
free:any = 3;
paid:any = 16;
}




