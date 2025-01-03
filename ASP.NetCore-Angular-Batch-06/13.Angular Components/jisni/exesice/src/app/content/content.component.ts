import { Component } from '@angular/core';
import { Job } from '../job';



@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  blue: string = "#ad14d7";
  resetBlue: string = "rgb(202, 169, 232)";
  divBackgroundColor1: string = "rgb(202, 169, 232)";
  divBackgroundColor2: string = "rgb(202, 169, 232)";
  divBackgroundColor3: string = "rgb(202, 169, 232)";
  divBackgroundColor4: string = "rgb(202, 169, 232)";
  divBackgroundColor5: string = "rgb(202, 169, 232)";

resetBackground(resetNumber: any) {

  switch (resetNumber) {
    case 1: this.divBackgroundColor1 = this.resetBlue;
      break;
    case 2: this.divBackgroundColor2 = this.resetBlue;
      break;
    case 3: this.divBackgroundColor3 = this.resetBlue;
      break;
    case 4: this.divBackgroundColor4 = this.resetBlue;
      break;
    case 5: this.divBackgroundColor5 = this.resetBlue;
      break;
  }

}


jobs: Job[] =
[{

  id: " #APL-0003",
  dateapplied: "MosciskiInc.",
  company: "FREELANCE",
  type: "PART TIME",
  position: "Intern UI Designer",
  contact: "./../assets/image/phone.png"||"./../assets/image/email.png",
  status: "Pending"

},

{
id: " #APL-0003",
dateapplied: "MosciskiInc.",
type: "PART TIME",
company: "FREELANCE",
position: "Intern UI Designer",
contact: "./../assets/image/phone.png"||"./../assets/image/email.png",
status: "On-Hold"
},

{
  id: " #APL-0003",
  dateapplied: "June 2, 2020, 09:22 AM",
  type: "PART TIME",
  company: "TCS IT Department",
  position: "Intern UI Designer",
  contact: "./../assets/image/phone.png"||"./../assets/image/email.png",
  status: "Pending"
  },

  {
    id: " #APL-0003",
    dateapplied: "MosciskiInc.",
    type: "PART TIME",
    company: "FREELANCE",
    position: "Intern UI Designer",
    contact: "./../assets/image/phone.png"||"./../assets/image/email.png",
    status: "Candidate"
    },

    {
      id: " #APL-0003",
      dateapplied: "MosciskiInc.",
      type: "PART TIME",
      company: "FREELANCE",
      position: "Intern UI Designer",
      contact: "./../assets/image/phone.png"||"./../assets/image/email.png",
      status: "On-Hold"
      },
      {
        id: " #APL-0003",
        dateapplied: "MosciskiInc.",
        type: "PART TIME",
        company: "FREELANCE",
        position: "Intern UI Designer",
        contact: "./../assets/image/phone.png"||"./../assets/image/email.png",
        status: "Candidate"
        }

      
    ]
    totalJobs:number=this.jobs.length;
  tempJobs: Job[] = this.jobs;
  filter(jobName: string) {
     let tempJobs:Job[]=this.jobs;
    if (jobName === "All") {
      console.log("all");
      return this.tempJobs = this.jobs;
      console.log(this.tempJobs)
    }
    else {
      console.log(jobName)
      const filteredJobs: Job[] = this.jobs.filter(jobs => Object.values(jobs).some(value => typeof value === 'string' && value.toLowerCase().includes(jobName.toLowerCase())));
      return this.tempJobs = filteredJobs;
    }
  }

}


       
