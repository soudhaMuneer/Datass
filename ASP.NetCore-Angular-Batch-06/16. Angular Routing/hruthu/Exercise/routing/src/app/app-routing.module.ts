import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContentComponent } from './content/content.component';
import { MyapplicationComponent } from './myapplication/myapplication.component';

const routes: Routes = [
  {path:'alljobs',component:ContentComponent},
  {path:'myapplication',component:MyapplicationComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
