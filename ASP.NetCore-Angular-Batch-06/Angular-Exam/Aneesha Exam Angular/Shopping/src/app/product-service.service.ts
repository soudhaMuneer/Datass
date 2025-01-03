import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {

  constructor(private http:HttpClient) { }

   getElement(){
    return this.http.get<any>('http://localhost:3000/Products');
   }
   Delete(id : any){
    return this.http.delete<any>(`http://localhost:3000/Products/${id}`)
   }

  //  postElement(){
  //   return this.http.post
  //  }
}
