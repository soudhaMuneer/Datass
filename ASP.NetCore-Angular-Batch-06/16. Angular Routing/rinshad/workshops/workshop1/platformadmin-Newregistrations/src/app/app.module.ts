import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { JobprovidersComponent } from './jobproviders/jobproviders.component';
import { NewregistrationComponent } from './newregistration/newregistration.component';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    JobprovidersComponent,
    NewregistrationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
