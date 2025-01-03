import { Component, Input } from '@angular/core';
// import{}
@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent {
  @Input() childdata:any;
  @Input() btnclick:boolean=false;
   btnclick1:boolean=false;
   btnclick2:boolean=false;
   btnclick3:boolean=false;


  // demo:string=""
  shodesc(){
    this.btnclick1=true;
    this.btnclick2=false;
    this.btnclick3=false;
    

    
  }
  shodesc1(){
    this.btnclick1=false;
    this.btnclick2=true;
    this.btnclick3=false;
    }
  shodesc2(){
    this.btnclick1=false;
    this.btnclick2=false;
    this.btnclick3=true;
  }



}
