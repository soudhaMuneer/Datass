import { Component } from '@angular/core';
import { FormGroup, Validators, FormControl } from '@angular/forms';


@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})

export class ContentComponent {
  reactiveForm: any = {} ;

  constructor(private service: Service) { }


  sendForm() {
    this.reactiveForm = new FormGroup({
      jobTitle: new FormControl(null, Validators.required),
      date: new FormControl(null, Validators.required),
      time: new FormControl(null, Validators.required),
      location: new FormControl(null, Validators.required),
      notification: new FormControl(null, Validators.required),
    })
  }

  sendForm() {
    console.log(this.reactiveForm);
    this.reactiveForm = this.reactiveForm.value;
    this.router.navigate(['/data'])
    if (this.reactiveForm.valid){
      alert('Form submitted successfully')
    }else {
      alert('invalid form')
    }
   } 


}




// import { Component, OnInit } from '@angular/core';
// import { FormGroup, Validators, FormControl } from '@angular/forms';

// import { Router } from '@angular/router';
// @Component({
//   selector: 'app-content',
//   templateUrl: './content.component.html',
//   styleUrls: ['./content.component.css']
// })

// export class ContentComponent implements OnInit {
//   reactiveForm: FormGroup ;

//   constructor(private router: Router) {}

//   ngOnInit() {
//     this.reactiveForm = new FormGroup({
//       jobTitle: new FormControl(null, Validators.required),
//       date: new FormControl(null, Validators.required),
//       time: new FormControl(null, Validators.required),
//       location: new FormControl(null, Validators.required),
//       notification: new FormControl(null, Validators.required),
//     })
//   }

//   sendForm() {
//     console.log(this.reactiveForm);
//     this.reactiveForm = this.reactiveForm.value;
//     this.router.navigate(['/data'])
//     if (this.reactiveForm.valid){
//       alert('Form submitted successfully')
//     }else {
//       alert('invalid form')
//     }
//    } 
// }




































