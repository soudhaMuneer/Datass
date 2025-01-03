import { Component, Input } from '@angular/core';
import { JobClass } from '../parent/job';


@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent {
  @Input()arry1:JobClass[]=[];


}
