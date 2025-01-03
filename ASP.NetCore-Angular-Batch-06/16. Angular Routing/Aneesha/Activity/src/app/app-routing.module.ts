import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutUsComponent } from './about-us/about-us.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { LoginComponent } from './login/login.component';
import { JoblistComponent } from './joblist/joblist.component';
import { UserprofileComponent } from './userprofile/userprofile.component';
import { LogoutComponent } from './logout/logout.component';
import { JobSeekingAppComponent } from './job-seeking-app/job-seeking-app.component';


const routes: Routes = [

  {path: '',redirectTo : '/job-seeking-app',pathMatch: 'full'},
  {path: 'job-seeking-app',component:JobSeekingAppComponent},
  {path: 'home',component:HomeComponent},
  {path: 'about-us',component:AboutUsComponent},
  {path: 'contact-us',component:ContactUsComponent},
  {path: 'login',component:LoginComponent},
  {path: 'joblist',component:JoblistComponent},
  {path: 'userprofile',component:UserprofileComponent},
  {path: 'logout',component:LogoutComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
