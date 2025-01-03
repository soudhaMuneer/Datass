import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { FooterComponent } from './footer/footer.component';
import { SecondfooterComponent } from './secondfooter/secondfooter.component';
import { NavbarComponent } from './navbar/navbar.component';
import { AlljobsComponent } from './alljobs/alljobs.component';
import { MyapplicationsComponent } from './myapplications/myapplications.component';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    FooterComponent,
    SecondfooterComponent,
    NavbarComponent,
    AlljobsComponent,
    MyapplicationsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
