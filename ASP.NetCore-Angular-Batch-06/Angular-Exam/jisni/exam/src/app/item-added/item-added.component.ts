import { Component} from '@angular/core';
import { ItemService } from '../item.service';
@Component({
  selector: 'app-item-added',
  templateUrl: './item-added.component.html',
  styleUrls: ['./item-added.component.css']
})
export class ItemAddedComponent {
  newitem = { name: '', price: 0 };

  constructor(private itemService: ItemService) {}

  addeditem() {
    this.itemService.additem(this.newitem)
      .subscribe(() => {
        console.log('item added successfully');
        this.newitem = { name: '', price: 0 };
      }, error => {
        console.error('Error adding item:', error);
      });
        }
     
}
