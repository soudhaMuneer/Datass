import { Component,OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup,Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  reactiveForm: FormGroup;

  ngOnInit(){
    this.reactiveForm = new FormGroup({
      
      username: new FormControl(null, Validators.required),
      email: new FormControl(null, [Validators.required, Validators.email]),
      password: new FormControl(null, Validators.required),

      
      })
    }
    OnFormSubmitted(){
      console.log(this.reactiveForm);
      if (this.reactiveForm.valid){
        alert('Form submitted successfully')
      }else {
        alert('invalid form')
      }
    }
}
