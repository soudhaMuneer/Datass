import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ItemService {
  constructor(private http: HttpClient) {}

  additem(item: any): Observable<any> {
    return this.http.post('http://localhost:3000/itemss', item);
  }

  getitem(): Observable<any[]> {
    return this.http.get<any[]>('http://localhost:3000/itemss');
  }

  deleteitem(id: number) {
    return this.http.delete(`http://localhost:3000/itemss/${id}`);
  }
 
}
