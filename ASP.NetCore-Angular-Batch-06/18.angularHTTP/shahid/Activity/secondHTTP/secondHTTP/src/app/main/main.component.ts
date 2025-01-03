import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';
import { details } from './studentarr';
import { Router } from '@angular/router';



@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit{
  
 constructor(private empService:StudentService,private router:Router){} 
studentArray:details[]=[];
  ngOnInit() {
    this.empService.getStudents().subscribe((res:details[]) => {this.studentArray = res;
      console.log(this.studentArray);
      
    });
  }


  data = {
    id : "",
    name:"",
    age:"",
    gender:""
  }
 
  onSubmit(){
    this.empService.poststudents(this.data).subscribe((res:any)=> {
      console.log({res})
      alert( "Data inserted successfully");
      if (res.success===1) {
        this.studentArray
        
      }
    })
  }
   
  navigateToEdit(id:any){
    
  }
 

  navigateToDelete(id:any){
  //   if(confirm('Are you sure you want detele')){
  //   this.empService.deleteStudents(id).subscribe((res:any)=>{
  //     if (res.succes===1) {
  //       this.ngOnInit()
  //     }
  //   })
  // }
  this.empService.deleteStudents(id).subscribe()
}
}
