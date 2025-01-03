import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InterviewListComponent } from './interview-list/interview-list.component';
import { JobListComponent } from './job-list/job-list.component';

const routes: Routes = [
  {path:'interviewList', component: InterviewListComponent},
  {path:'jobList', component: JobListComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
