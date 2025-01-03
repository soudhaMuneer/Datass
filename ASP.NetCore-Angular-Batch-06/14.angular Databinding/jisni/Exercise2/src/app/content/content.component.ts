import { Component } from '@angular/core';
import { job } from '../jobpersonslist';


@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  job:job [];
  filteredjob :job[];
  constructor() {
    this.job = [
      {
        image1:"../../assets/Image/man-isolated-showing-facial-emotions 1.png",
        Name: "Alen",
        education: "MCA",
        experince:"3 Years",
        location:"Banglore",
        view:"view"

      },
      {
        image1:"../../assets/Image/cheerful-curly-business-girl-wearing-glasses 2.png",
        Name: "Sarah",
        education: "MSc",
        experince:"2 Years",
        location:"Chennai",
        view:"view"

      },
      {
        image1: "../../assets/Image/adult-serious-businessman-looking-camera 1.png",
        Name: "vivek",
        education: "B-tech/CSE",
        experince:"5 Years",
        location:"Thiruvananthapuram",
        view:"view"
       
      },
      {
        image1: "../../assets/Image/cheerful-indian-businessman-smiling-closeup-portrait-jobs-career-campaign 2.png",
        Name: "DeepakRoy",
        education: "BTech/EEE",
        experince:"2 Years",
        location:"Calicut",
        view:"view"
      }];

      this.filteredjob = this.job;
    }
      filterperson(event: Event): void {
        const searchTerm = (event.target as HTMLInputElement).value;
        this.filteredjob = this.job.filter(job =>
          job.Name.toLowerCase().includes(searchTerm.toLowerCase()) ||
          job.education.toLowerCase().includes(searchTerm.toLowerCase())||
          job.location.toLowerCase(). includes(searchTerm.toLowerCase())||
          job.experince.toLowerCase().includes(searchTerm.toLowerCase())
        );
      }
    
}
