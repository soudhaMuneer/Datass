import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {
  students: any[] = [];

  constructor(private studentService: StudentService) {}

  ngOnInit() {
    this.fetchStudents();
  }

  fetchStudents() {
    this.studentService.getStudents()
      .subscribe(data => {
        this.students = data;
        console.log(this.students)
      }, error => {
        console.error('Error fetching students:', error);
      });
  }

  removeStudent(id: number) {
    this.studentService.removeStudent(id)
      .subscribe(() => {
        console.log('Student removed successfully');
        // After successful removal, update the list of students
        this.students = this.students.filter(student => student.id !== id);
      }, error => {
        console.error('Error removing student:', error);
      });
  }
}
