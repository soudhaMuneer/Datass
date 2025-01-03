import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NewRegistrationsComponent } from './new-registrations/new-registrations.component';
import { JobprovidersComponent } from './jobproviders/jobproviders.component';

const routes: Routes = [
  { path: '', redirectTo:'/Profile' ,pathMatch:'full' },
  { path: 'registrations', component:NewRegistrationsComponent},
  { path: 'job', component: JobprovidersComponent },
  { path: 'Dashboard', component:NewRegistrationsComponent},
  { path: 'Profile', component:JobprovidersComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
