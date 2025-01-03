import { Component } from '@angular/core';

@Component({
  selector: 'app-postform',
  templateUrl: './postform.component.html',
  styleUrls: ['./postform.component.css']
})
export class PostformComponent {
  studentArray :any [] = [
    {
      id : "0",
      name:"shahid",
      age:"12",
      gender:"male"
    }
  ];
  data = {
    id : "",
    name:"",
    age:"",
    gender:""
  }
  onSubmit(){
    this.studentArray.push(this.data);

  }
  navigateToEdit(){

  }
  navigateToDelete(s:any){
    this.studentArray.splice(s,1)
  }

}
