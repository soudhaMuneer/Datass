import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-template',
  templateUrl: './template.component.html',
  styleUrls: ['./template.component.css']
})
export class TemplateComponent {

            

  OnFormSubmitted(form: NgForm){
    console.log(form);
  }

}

// import { ViewChild } from '@angular/core';

 // @ViewChild('registrationForm') form: NgForm;
                // Or
   
  // OnFormSubmitted(){
  //      console.log(this.form);
  //  }   