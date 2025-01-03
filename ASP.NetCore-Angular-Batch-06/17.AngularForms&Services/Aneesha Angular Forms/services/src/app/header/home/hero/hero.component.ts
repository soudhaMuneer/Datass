import { Component } from '@angular/core';
import { SubscribeService } from '../../../Services/subscribe.service';

@Component({
  selector: 'app-hero',
  templateUrl: './hero.component.html',
  styleUrls: ['./hero.component.css'],
  providers: [SubscribeService] //2.What to provide
})
export class HeroComponent {

  // 1.How to provide dependancy
  constructor(private SubService: SubscribeService){

  }
  //services
  // OnSubscribe(){
  //   // Add user to Database
  //   // send email with subscrption
  //   // Allow user to access the service
   
  //   let SubService = new SubscribeService();
  //   SubService.OnSubscribeClicked('Montly');
  // }

  OnSubscribe(){
    this.SubService.OnSubscribeClicked('Quaterly');
  }
}
