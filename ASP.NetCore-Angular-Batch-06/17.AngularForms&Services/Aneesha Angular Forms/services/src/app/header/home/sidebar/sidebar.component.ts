import { Component } from '@angular/core';
import { SubscribeService } from '../../../Services/subscribe.service';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css'],
  providers: [SubscribeService] //2.What to provide
})
export class SidebarComponent {

  // 1.How to provide dependancy
  constructor(private SubService: SubscribeService){

  }
  //Service
  // OnSubscribe(){
  //   // Add user to Database
  //   // send email with subscrption
  //   // Allow user to access the service
  //   let SubService = new SubscribeService();
  //   SubService.OnSubscribeClicked('yearly');
  // }
  // Dependacy injection
   
  OnSubscribe(){
    this.SubService.OnSubscribeClicked('Quaterly');
  }
}
