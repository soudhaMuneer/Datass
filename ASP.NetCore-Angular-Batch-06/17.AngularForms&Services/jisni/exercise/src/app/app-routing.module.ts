import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContentComponent } from './content/content.component';
import { MyApplicationComponent } from './my-application/my-application.component';



const routes: Routes = [
 
 
  { path: 'content', component: ContentComponent },
  { path: 'my-application', component: MyApplicationComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
