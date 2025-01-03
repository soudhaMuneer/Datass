
import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent {
    //  course=[
    //   {
    //     coursename :".net developer",
    //     id : "1",
    //     type: "All"
    //   },
    //   {
    //     coursename :".net free",
    //     id : "2",
    //     type: "Free"
    //   },
    //   {
    //     coursename :".net paid",
    //     id : "3",
    //     type: "Paid"
    //   },
    //   {
    //     coursename :".net all",
    //     id : "4",
    //     type: "All"
    //   },
    //  ];

    //  getAll(){
    //   return this.course;
    //  }

    //  all :string="5";
    //  free :string="2";
    //  paid :string="6";
   
    messageFromChild:string | undefined;
    getData(dataFromChild:string){
      this.messageFromChild=dataFromChild;
    }
    
}

