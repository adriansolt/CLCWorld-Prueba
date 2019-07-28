import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TelephoneListComponent } from './telephone-list/telephone-list.component';
import { TelephoneDetailsComponent } from './telephone-details/telephone-details.component';


const routes: Routes = [
  { path: '', redirectTo: 'telephones', pathMatch: 'full' },
  { path: 'telephones', component: TelephoneListComponent },
  { path: 'telephones/:id', component: TelephoneDetailsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
