import { Component } from '@angular/core';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-student-registration',
  templateUrl: './student-registration.component.html',
  styleUrls: ['./student-registration.component.css']
})
export class StudentRegistrationComponent {
  newStudent = { name: '', age: 1, grade: '' };

  constructor(private studentService: StudentService) {}

  registerStudent() {
    this.studentService.registerStudent(this.newStudent)
      .subscribe(() => {
        console.log('Student registered successfully');
        this.newStudent = { name: '', age: 0, grade: '' };
      }, error => {
        console.error('Error registering student:', error);
      });
    
  }
}
