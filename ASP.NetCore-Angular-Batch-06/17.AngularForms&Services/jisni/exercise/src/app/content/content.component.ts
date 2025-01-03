import { Component,OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, FormBuilder } from '@angular/forms';
import { ServiceService } from '../service.service';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent  {
  reactiveForm: FormGroup ;
  showList: boolean = false;
  
  constructor(private formBuilder: FormBuilder, private serviceService: ServiceService) {
    this.reactiveForm = this.formBuilder.group({
      jobTitle: ['', Validators.required],
      date: ['', Validators.required],
      time: ['', Validators.required],
      location: ['', Validators.required ],
      
     
    });
  }

  sendForm() {
    console.log(this.reactiveForm);
    if (this.reactiveForm.valid){
      alert('Form submitted successfully')
      const memberData = {
        jobTitle: this.reactiveForm.value.jobtitle,
        date: this.reactiveForm.value.date,
        time: this.reactiveForm.value.time,
        location: this.reactiveForm.value.location,
        
      };
      this.serviceService.registerMember(memberData);
      this.showList = true;

      
    
    }
    else {
      alert('invalid form')
    }
  }
  
}
