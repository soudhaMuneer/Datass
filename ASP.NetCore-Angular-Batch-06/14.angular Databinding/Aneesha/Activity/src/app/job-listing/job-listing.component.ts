import { Component } from '@angular/core';

@Component({
  selector: 'app-job-listing',
  templateUrl: './job-listing.component.html',
  styleUrls: ['./job-listing.component.css']
})
export class JobListingComponent {
  jobAvailable = true;

  applyNow() {
    this.jobAvailable = !this.jobAvailable;
  }
  Onsubmit(){
    alert('sumbitted successfully')
  }

  save(){
    this.jobAvailable = !this.jobAvailable;
    
  }

  ok(){
    this.jobAvailable = !this.jobAvailable;
  }
}
