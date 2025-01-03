import { Component } from '@angular/core';
import { SubscribeService } from '../Services/subscribe.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  providers: [SubscribeService] //2.What to provide
})
export class HeaderComponent {
  // 1.How to provide dependancy
  constructor(private SubService: SubscribeService){

  }
  // service.......
  // OnSubscribe(){
  //   // Add user to Database
  //   // send email with subscrption
  //   // Allow user to access the service
  //   let SubService = new SubscribeService();
  //   SubService.OnSubscribeClicked('Montly');
  // }

  // Dependancy injection

  OnSubscribe(){
    this.SubService.OnSubscribeClicked('Quaterly');
  }
}
