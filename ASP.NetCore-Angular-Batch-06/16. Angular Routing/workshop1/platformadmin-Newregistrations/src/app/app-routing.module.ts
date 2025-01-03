import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NewRegistrationsComponent } from './new-registrations/new-registrations.component';
import { JobprovidersComponent } from './jobproviders/jobproviders.component';

const routes: Routes = [
  { path: ' ', redirectTo : '/jobproviders', pathMatch: 'full'},
  { path: 'new-registrations', component:NewRegistrationsComponent},
  { path: 'jobproviders', component: JobprovidersComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
