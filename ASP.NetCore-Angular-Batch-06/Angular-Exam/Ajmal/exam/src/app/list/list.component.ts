import { Component } from '@angular/core';
import { ItemService } from '../item.service';
import { list } from '../itemdata';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent {
constructor(private service:ItemService){}
items:list[]=[]
  ngOnInit(){
    this.service.getItem().subscribe((data:list[])=>
    {
      this.items=data;
    })

  }
  deleteitem(id:any)
  {
    alert( 'delete'+id);
    console.log(id);

    this.service.deleteItem(id).subscribe()
    this.ngOnInit();
  
  }

}
