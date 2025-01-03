import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent {
  @Input() selectedOption: any;
  @Input() btnclick:boolean=false;

  btnclick1:boolean=false;
  btnclick2:boolean=false;
  btnclick3:boolean=false;

  shodesc(){
    this.btnclick1=true;
    this.btnclick2=false;
    this.btnclick3=false;
  }

  shodesc1(){
    this.btnclick1=true;
    this.btnclick2=false;
    this.btnclick3=false;
  }

  shodesc2(){
    this.btnclick1=true;
    this.btnclick2=false;
    this.btnclick3=false;
  }


}
