import { Component } from '@angular/core';

@Component({
  selector: 'app-joblisting',
  templateUrl: './joblisting.component.html',
  styleUrls: ['./joblisting.component.css']
})
export class JoblistingComponent {
JobAvailable:boolean= true;
ToggleJobAvailability(){

  this.JobAvailable=!this.JobAvailable;

}

}
