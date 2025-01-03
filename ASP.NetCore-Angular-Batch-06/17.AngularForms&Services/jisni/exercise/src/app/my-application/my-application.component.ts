import { Component } from '@angular/core';
import { ServiceService } from '../service.service';
@Component({
  selector: 'app-my-application',
  templateUrl: './my-application.component.html',
  styleUrls: ['./my-application.component.css']
})
export class MyApplicationComponent {
  registeredMembers: any[];

  constructor(private serviceService: ServiceService) {
    this.registeredMembers = serviceService.getRegisteredMembers();
  }
}
