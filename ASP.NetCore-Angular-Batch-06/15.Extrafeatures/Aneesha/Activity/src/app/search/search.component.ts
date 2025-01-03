import { Component,Input } from '@angular/core';
import { Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})

export class SearchComponent {

  //  @Input() item : string ="";
  //  @Input() Free : string ="";
  //  @Input() Paid : string ="";

   
  //  @Input() Child :any;

   data: string="message from child";
   @Output() message =new EventEmitter<string>;  
 notify(){
  this.message.emit(this.data);
 }
  

}
