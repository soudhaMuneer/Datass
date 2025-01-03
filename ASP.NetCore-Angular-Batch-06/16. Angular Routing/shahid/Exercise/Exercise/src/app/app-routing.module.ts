import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JobsComponent } from './jobs/jobs.component';
import { NewRegistrationsComponent } from './new-registrations/new-registrations.component';
import { DashboardComponent } from './dashboard/dashboard.component';

const routes: Routes = [
  {path:'',redirectTo:'/dashboard',pathMatch: 'full'},
  {path:'dashboard',component:DashboardComponent},
  {path:'jobs',component:JobsComponent},
  {path:'new-registrations',component:NewRegistrationsComponent}
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
