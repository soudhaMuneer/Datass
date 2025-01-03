import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JoblisslingsComponent } from './joblisslings/joblisslings.component';
import { HomeComponent } from './home/home.component';
import { UserprofileComponent } from './userprofile/userprofile.component';
import { LogoutComponent } from './logout/logout.component';
const routes: Routes = [
  { path: 'job-listings',component:JoblisslingsComponent },
  { path:'home' ,component: HomeComponent },
  { path: 'user-profile',component :UserprofileComponent },
  { path: 'logout', component : LogoutComponent}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
