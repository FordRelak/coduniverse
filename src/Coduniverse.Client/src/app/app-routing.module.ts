import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormComponent } from './form/form.component';
import { StarSystemComponent } from './star-system/star-system.component';

const routes: Routes = [
  { path: "form", component: FormComponent },
  { path: "", component: StarSystemComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
