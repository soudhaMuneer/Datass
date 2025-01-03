import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators, FormArray } from '@angular/forms';

@Component({
  selector: 'app-registration-form',
  templateUrl: './registration-form.component.html',
  styleUrls: ['./registration-form.component.css']
})
export class RegistrationFormComponent {
  reactiveForm: FormGroup;

 

  ngOnInit(){
    
    this.reactiveForm = new FormGroup({
      fullname: new FormControl(null, Validators.required ),
      lastname: new FormControl(null, Validators.required ),
      email: new FormControl(null, [Validators.required, Validators.email]),
      phonenumber: new FormControl(null, [Validators.required,Validators.pattern('[0-9]{10}')])

      
      })
    }
    onSubmit(){
      console.log(this.reactiveForm);
      if (this.reactiveForm.valid){
        alert('Form submitted successfully')
      }else {
        alert('invalid form')
      }
    }
}