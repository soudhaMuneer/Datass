import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { list } from './itemdata';

@Injectable({
  providedIn: 'root'
})
export class ItemService {
src="http://localhost:3000/items"
source="http://localhost:3000/items/"
  constructor(private http:HttpClient, ) { }
getItem(){
 return this.http.get<list[]>(this.src)
}
postItem(data:list){
  return this.http.post(this.src,data)
}
deleteItem(id:any){
  return this.http.delete(`${this.source}${id}`);
}
}
