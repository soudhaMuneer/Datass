import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { NgForm } from '@angular/forms';


@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http :HttpClient) { }

  getStudents(){
    return this.http.get<any>('http://localhost:3000/abid')
  }

  poststudents(data:any){
    return this.http.post<any>('http://localhost:3000/abid',data)
  }
  deleteStudents(id:any){
        return this.http.delete<any>(`http://localhost:3000/abid/${id}`);
  }
}
