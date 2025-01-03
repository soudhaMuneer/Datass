import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-filtercomponent',
  templateUrl: './filtercomponent.component.html',
  styleUrls: ['./filtercomponent.component.css']
})
export class FiltercomponentComponent {


   @Input() all:Number = 0;
   @Input() free:any="";
   @Input() paid:any ="";
   
   
}
