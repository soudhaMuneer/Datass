import { Component } from '@angular/core';
import { joblist } from '../content/joblist';
@Component({
  selector: 'app-myapplication',
  templateUrl: './myapplication.component.html',
  styleUrls: ['./myapplication.component.css']
})
export class MyapplicationComponent {
  jobs:joblist[]=[]
  filterdjobs:joblist[]=[]
  constructor(){
    this.jobs=[
      {
        companylogo:"../../assets/image/Rectangle 14.png",
        post: "Customer Service Representative",
        companyname: "ServiceFirst Corporation",
        location: ".Chicago",
        details:"We are looking for a UI/UX Designer to turn our software into easy-to- use products for our clients."
      },
      {
        companylogo:"../../assets/image/Rectangle 14 (1).png",
        post: "Graphic Designer",
        companyname: "Creative Designs Studio",
        location: ".Los Angeles",
        details:"We are looking for a UI/UX Designer to turn our software into easy-to- use products for our clients."
      },
      {
        companylogo:"../../assets/image/Rectangle 14 (1).png",
        post: "Sales Associate",
        companyname: "Retail Solutions Ltd.",
        location: ".Miami",
        details:"We are looking for a UI/UX Designer to turn our software into easy-to- use products for our clients."
        
      }
    ]
    this.filterdjobs=this.jobs
  }
  
  filterJobs(evant: Event):void{
    const searchTerm = (evant.target as HTMLInputElement).value;
    this.filterdjobs = this.jobs.filter(jobs=>
      jobs.companyname?.toLocaleLowerCase().includes(searchTerm.toLocaleLowerCase()) ||
      jobs.post?.toLocaleLowerCase().includes(searchTerm.toLocaleLowerCase())
      );
  }
  
  
  

}
