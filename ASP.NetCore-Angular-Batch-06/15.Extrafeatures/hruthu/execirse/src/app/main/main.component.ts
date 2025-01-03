import { Component } from '@angular/core';
import { jobdata } from '../details';
@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent {
  store:jobdata[]=[]
  filteredJobs:jobdata[];
  tempfile:any;
  constructor(){
    this.store=[
      {
        companylogo:"../../assets/images/abc.png",
        companyname:"Tcs",
        jobpost:"Software Engineer",
        description:"we are looking for a Software Engineer to turn our software into easy-to-use.",
        location:"thrissur",    
        saved:"../../assets/images/Group 5696.png",
        back:"../../assets/images/googleCover.jpg"
      },
      {
        companylogo:"../../assets/images/aitrich.png",
        companyname:"Infosys",
        jobpost:"Dot Net developer",
        description:"we are looking for a Dot Net developer to turn our software into easy-to-use.",
        location:"thrissur",
        saved:"../../assets/images/Group 5696.png",
        back:"../../assets/images/googleCover2.jpg"
      },
      {
        companylogo:"../../assets/images/Rectangle 14 (1).png",
        companyname:"Aitrich",
        jobpost:"Angular",
        description:"we are looking for a Angular developer to turn our software into easy-to-use.",
        location:"thrissur",
        saved:"../../assets/images/Group 5696.png",
        back:"../../assets/images/googleCover.jpg"
      },
      {
        companylogo:"../../assets/images/Rectangle 14.png",
        companyname:"IBM",
        jobpost:"Marketing Manager",
        description:"we are looking for a Marketing Manager to turn our software into easy-to-use.",
        location:"thrissur",
        saved:"../../assets/images/Group 5696.png",
        back:"../../assets/images/googleCover2.jpg"
      },
      {
        companylogo:"../../assets/images/Rectangle 14 (2).png",
        companyname:"EY",
        jobpost:"Customer Service Representative",
        description:"we are looking for a Customer Service Representative to turn our software into easy-to-use.",
        location:"thrissur",
        saved:"../../assets/images/Group 5696.png",
        back:"../../assets/images/googleCover.jpg"
      }
    ];
    this.filteredJobs=this.store;
  }
  filterJobs(event: Event): void {
    const searchTerm = (event.target as HTMLInputElement).value;
    this.filteredJobs = this.store.filter(jobdata =>
      jobdata.companyname.toLowerCase().includes(searchTerm.toLowerCase()) ||
      jobdata.jobpost.toLowerCase().includes(searchTerm.toLowerCase())
    );
  }
  isclick:boolean=false;
  getfunction(data:any){
    this.isclick=true;
    this.tempfile=data;
  }

  
}
