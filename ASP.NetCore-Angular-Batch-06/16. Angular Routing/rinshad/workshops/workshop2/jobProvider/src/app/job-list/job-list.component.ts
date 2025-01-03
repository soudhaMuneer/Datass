import { Component } from '@angular/core';
import { job } from 'src/job';

@Component({
  selector: 'app-job-list',
  templateUrl: './job-list.component.html',
  styleUrls: ['./job-list.component.css']
})
export class JobListComponent {
  companies:job[];
  companyList: job[];
   constructor()
   {
    this.companies =[
     {
      companyLogo:"../../assets/images/image/amazon-png-logo-vector-6706 (1).png",
      job_post:"UX/UI Designer ",
      company_name:"Amazon",
      location:"Indonesia",
      time_schedule:"Full-time",
      salary_range:"3000-5000"

     }, 
     {
      companyLogo:"../../assets/images/image/shopee.png",
      job_post:"Product Designer",
      company_name:"Shopee",
      location:"USA",
      time_schedule:"Part-time",
      salary_range:"5000-1000"

     },
     {
      companyLogo:"../../assets/images/image/amazon-png-logo-vector-6706 (1).png",
      job_post:"Developer",
      company_name:"Amazon",
      location:"India",
      time_schedule:"Hybrid",
      salary_range:"4000-6000"

     }];
     this.companyList=this.companies;
    }
    filterCompanies(event: Event): void {
      const searchTerm = (event.target as HTMLInputElement).value;
      this.companyList= this.companies.filter(job =>
        job.company_name.toLowerCase().includes(searchTerm.toLowerCase())||
        job.location.toLowerCase().includes(searchTerm.toLowerCase())
          );
    }

}
