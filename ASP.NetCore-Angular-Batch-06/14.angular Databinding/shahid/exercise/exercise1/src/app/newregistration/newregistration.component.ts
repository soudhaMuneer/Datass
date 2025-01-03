import { Component } from '@angular/core';
import { newregistrationarr } from '../newregs';

@Component({
  selector: 'app-newregistration',
  templateUrl: './newregistration.component.html',
  styleUrls: ['./newregistration.component.css']
})
export class NewregistrationComponent {
  TotalNewReg :string = '45';
  bgcolor1="rgb(202, 169, 232)";
  bgcolor2="rgb(202, 169, 232)";
  bgcolor3="rgb(202, 169, 232)";
  bgcolor4="rgb(202, 169, 232)";
  reset ="rgb(202, 169, 232)"
  topurple: string = "rgb(151, 67, 230)";

  

  resetBackground(resetNumber: any) {

    switch (resetNumber) {
      case 1: this.bgcolor1 = this.reset;
        break;
      case 2: this.bgcolor2 = this.reset;
        break;
      case 3: this.bgcolor3 = this.reset;
        break;
      case 4: this.bgcolor4 = this.reset;
        break;
      
    }

  }
  hoverbg(resetNumber: any) {

    switch (resetNumber) {
      case 1: this.bgcolor1 = this.topurple;
        break;
      case 2: this.bgcolor2 = this.topurple;
        break;
      case 3: this.bgcolor3 = this.topurple;
        break;
      case 4: this.bgcolor4 = this.topurple;
        break;
      
    }

  }


  NewRegistration :newregistrationarr [] =[
    {
      id:"#ALP-003",
      Dateapplied:"June 1,2020,8:22AM",
      company:"mosciski Inc",
      type:"FREELANCE",
      position:"Intern UI Designer",
      contactph:"../../assets/images/phone.png",
      contactmsg:"../../assets/images/email (1) 1.png",
      status:"pending",
      color:"rounded-pill btn btn-outline-secondary"
          
    },
    {
      id:"#ALP-003",
      Dateapplied:"June 1,2020,8:22AM",
      company:"mosciski Inc",
      type:"FREELANCE",
      position:"Intern UI Designer",
      contactph:"../../assets/images/phone.png",
      contactmsg:"../../assets/images/email (1) 1.png",
      status:"On-Hold",
      color:"rounded-pill btn btn-outline-danger"
          
    },
    {
      id:"#ALP-003",
      Dateapplied:"June 1,2020,8:22AM",
      company:"mosciski Inc",
      type:"FREELANCE",
      position:"Intern UI Designer",
      contactph:"../../assets/images/phone.png",
      contactmsg:"../../assets/images/email (1) 1.png",
      status:"pending",
      color:"rounded-pill btn btn-outline-secondary"
          
    },
    {
      id:"#ALP-003",
      Dateapplied:"June 1,2020,8:22AM",
      company:"mosciski Inc",
      type:"FREELANCE",
      position:"Intern UI Designer",
      contactph:"../../assets/images/phone.png",
      contactmsg:"../../assets/images/email (1) 1.png",
      status:"Candidate",
      color:"rounded-pill btn btn-success"
          
    },
    {
      id:"#ALP-003",
      Dateapplied:"June 1,2020,8:22AM",
      company:"mosciski Inc",
      type:"FREELANCE",
      position:"Intern UI Designer",
      contactph:"../../assets/images/phone.png",
      contactmsg:"../../assets/images/email (1) 1.png",
      status:"On-Hold",
      color:"rounded-pill btn btn-outline-danger"
          
    },
    {
      id:"#ALP-003",
      Dateapplied:"June 1,2020,8:22AM",
      company:"mosciski Inc",
      type:"FREELANCE",
      position:"Intern UI Designer",
      contactph:"../../assets/images/phone.png",
      contactmsg:"../../assets/images/email (1) 1.png",
      status:"Candidate",
      color:"rounded-pill btn btn-success"
          
    }
        
  ];


  totalJobs:number=this.NewRegistration.length;
  tempNewRegistration: newregistrationarr[] = this.NewRegistration;
  filter(jobName: string) {
    // let tempJobs:Job[]=this.jobs;
    if (jobName === "All") {
      console.log("all");
      return this.tempNewRegistration = this.NewRegistration;
      console.log(this.tempNewRegistration)
    }
    else {
      console.log(jobName)
      const filteredJobs: newregistrationarr[] = this.NewRegistration.filter(NewRegistration => Object.values(NewRegistration).some(value => typeof value === 'string' && value.toLowerCase().includes(jobName.toLowerCase())));
      return this.tempNewRegistration = filteredJobs;
    }
  }
}
