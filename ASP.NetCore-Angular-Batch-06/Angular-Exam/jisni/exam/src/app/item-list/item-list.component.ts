
import { Component, OnInit } from '@angular/core';

import { ItemService } from '../item.service'; 

@Component({
  selector: 'app-item-list',
  templateUrl: './item-list.component.html',
  styleUrls: ['./item-list.component.css']
})
export class ItemListComponent implements OnInit {
  itemss: any[] = [];

  constructor(private itemService: ItemService) {}

  ngOnInit() {
    this.fetchitems();
  }

  fetchitems() {
    this.itemService.getitem()
      .subscribe(data => {
        this.itemss = data;
      }, error => {
        console.error('Error fetching item:', error);
      });
  }

  removeitem(id: number) {
    this.itemService. deleteitem(id)
      .subscribe(() => {
        console.log('item removed successfully');
        // After successful removal, update the list of students
        this.itemss = this.itemss.filter(items=> items.id !== id);
      }, error => {
        console.error('Error removing item', error);
      });
      
  }}