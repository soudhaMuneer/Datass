import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CourcecomponentComponent } from './courcecomponent/courcecomponent.component';
import { FiltercomponentComponent } from './filtercomponent/filtercomponent.component';

@NgModule({
  declarations: [
    AppComponent,
    CourcecomponentComponent,
    FiltercomponentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
