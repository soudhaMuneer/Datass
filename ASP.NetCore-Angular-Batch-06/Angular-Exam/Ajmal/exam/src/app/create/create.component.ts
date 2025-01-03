import { Component, OnInit } from '@angular/core';
import { ItemService } from '../item.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { list } from '../itemdata';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements  OnInit {
  formlist!:FormGroup
  constructor(private service:ItemService,private fb:FormBuilder, private router:Router){}
ngOnInit(){
  this.formlist=this.fb.group({
    name:['',Validators.required],
    Quantity:['',Validators.required],
    Price:['']
  })
}
 

    


submit(){
 const data:any={
    itemName:this.formlist.value.name,
    Quantity:this.formlist.value.Quantity,
    price:this.formlist.value.Price
   };

console.log(data)
this.router.navigate(["/list"]);
this.service.postItem(data).subscribe(res=>{
  console.log(res)
});
}

}
