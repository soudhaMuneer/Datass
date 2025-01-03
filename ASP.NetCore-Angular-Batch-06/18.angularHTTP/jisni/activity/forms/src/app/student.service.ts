import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  constructor(private http: HttpClient) {}

  registerStudent(student: any): Observable<any> {
    return this.http.post('http://localhost:3000/students', student);
  }

  getStudents(): Observable<any[]> {
    return this.http.get<any[]>('http://localhost:3000/students');
  }

  removeStudent(id: number) {
    return this.http.delete(`http://localhost:3000/students/${id}`);
  }
}
