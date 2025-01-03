import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DataComponent } from './data/data.component';
import { ContentComponent } from './content/content.component';

const routes: Routes = [
  {path: '',redirectTo:'/content',pathMatch:'full'},
  {path: 'data',component:DataComponent},
  {path: 'content',component:ContentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }






