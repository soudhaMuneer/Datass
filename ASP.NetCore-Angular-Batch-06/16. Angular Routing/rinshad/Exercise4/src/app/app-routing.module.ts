import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AlljobsComponent } from './alljobs/alljobs.component';
import { MyapplicationsComponent } from './myapplications/myapplications.component';

const routes: Routes = [
  { path:'alljobs', component: AlljobsComponent},
  {path: 'myapplications', component : MyapplicationsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
