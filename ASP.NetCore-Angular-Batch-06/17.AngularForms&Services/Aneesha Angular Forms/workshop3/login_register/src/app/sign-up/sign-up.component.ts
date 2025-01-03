import { Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from '../user.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent {

  @ViewChild('registrationForm') registrationForm!: NgForm;

  constructor(private userService: UserService, private router: Router) { }

  registerUser() {
    // Get form values
    const firstName = this.registrationForm.value.firstName;
    const lastName = this.registrationForm.value.lastName;
    const email = this.registrationForm.value.email;
    const phoneNumber = this.registrationForm.value.phoneNumber;
    const password = this.registrationForm.value.password;
    const confirmpassword = this.registrationForm.value.confirmpassword;
    const gender = this.registrationForm.value.gender;

    // Perform additional validation if needed
    if (password !== confirmpassword) {
      alert('Password and Confirm Password must match.');
      return;
    }

    // Create user object
    const user = {
      firstName,
      lastName,
      email,
      phoneNumber,
      password,
      gender
    };

    // Register the user
    this.userService.register(user);

    // Redirect to login
    this.router.navigate(['/login']);
  }


}
