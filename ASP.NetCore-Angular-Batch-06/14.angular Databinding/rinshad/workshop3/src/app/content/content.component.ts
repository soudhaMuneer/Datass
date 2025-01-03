import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  detailGroups: any[] = [
    {
     
     text1: '18',
     text2: 142,
     text3:  82
          
    }
  ];

  constructor() { }
}
