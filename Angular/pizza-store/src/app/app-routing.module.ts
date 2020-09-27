import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PizzaHomePageComponent } from './pizza-home-page/pizza-home-page.component';

const routes: Routes = [
  { path: 'pizza-home-page', component: PizzaHomePageComponent },
  { path: '',   redirectTo: '/pizza-home-page', pathMatch: 'full' }, // redirect to `Pizza Home Page Component`
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
