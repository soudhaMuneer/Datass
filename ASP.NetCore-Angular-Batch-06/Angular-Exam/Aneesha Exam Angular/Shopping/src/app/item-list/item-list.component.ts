import { Component,OnInit } from '@angular/core';
import { ProductServiceService } from '../product-service.service';
import { Router } from '@angular/router';
import { Products } from './model';

@Component({
  selector: 'app-item-list',
  templateUrl: './item-list.component.html',
  styleUrls: ['./item-list.component.css']
})


export class ItemListComponent implements OnInit {
   StudentDetails :Products[] = [];
  constructor( private empService:ProductServiceService ,private router:Router){}
   
  ngOnInit(){
    this.empService.getElement().subscribe((UserData :Products[])=>{
      this.StudentDetails=UserData;
    })
  }
  Remove(id : any){
     this.empService.Delete(id).subscribe((UserData :Products[])=>{
      this.StudentDetails=UserData;
      this.empService.getElement().subscribe((UserData :Products[])=>{
        this.StudentDetails=UserData;
      });
     })
  }

  AddNew(){
    this.router.navigate(['/add-product'])
  }

 

}
