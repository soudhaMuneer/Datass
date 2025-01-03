import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup,Validators } from '@angular/forms';


@Component({
  selector: 'app-reactive',
  templateUrl: './reactive.component.html',
  styleUrls: ['./reactive.component.css']
})


export class ReactiveComponent implements OnInit {
  reactiveForm: FormGroup;

  ngOnInit(){
    this.reactiveForm = new FormGroup({
      firstName: new FormControl(null, Validators.required),
      lastName: new FormControl(null, Validators.required),
      userName: new FormControl(null, Validators.required),
      mobileNumber: new FormControl(null, [Validators.required, Validators.pattern('[0-9]{10}')]),
      email: new FormControl(null, [Validators.required, Validators.email]),
      password: new FormControl(null, Validators.required),
      // Form Array

    skills: new FormArray([
      new FormControl(null,Validators.required),
      
    ]),
    experience: new FormArray([
      new FormGroup({
      })
    ])
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

  AddSkills(){
    (<FormArray> this.reactiveForm.get('skills'))
    .push ( new FormControl(null,Validators.required))
  }
  
  DeleteSkill(index: number){
   const controls = (<FormArray> this.reactiveForm.get('skills'));
   controls.removeAt(index)
  }

  AddExperience(){
    const formGroup = new FormGroup({
      jobtitle: new FormControl(null),
      company: new FormControl(null),
      duration: new FormControl(null),
      responsibilities: new FormControl(null),
    });
    (<FormArray>this.reactiveForm.get('experience')).push(formGroup)
  }

  DeleteExperience(index: number){
    const controls = (<FormArray> this.reactiveForm.get('experience'));
    controls.removeAt(index)
  }

}
