import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JobprovidersComponent } from './jobproviders/jobproviders.component';
import { NewRegistrations } from './newRegistrations';
import { NewregistrationComponent } from './newregistration/newregistration.component';

const routes: Routes = [
  { path: 'jobproviders', component: JobprovidersComponent },
  { path: 'new-registrations',component: NewregistrationComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
