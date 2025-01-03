import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditcomponentComponent } from './editcomponent/editcomponent.component';

const routes: Routes = [
  { path: 'editdetails',component:EditcomponentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
