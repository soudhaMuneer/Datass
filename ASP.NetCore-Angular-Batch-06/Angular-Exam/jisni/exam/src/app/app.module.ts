import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ItemListComponent } from './item-list/item-list.component';
import{HttpClientModule} from '@angular/common/http';
import { ItemAddedComponent } from './item-added/item-added.component'
@NgModule({
  declarations: [
    AppComponent,
    
    ItemListComponent,
         ItemAddedComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
