import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DogBreedListComponent } from './components/dog-breed-list/dog-breed-list.component';
import { DogBreedDetailsComponent } from './components/dog-breed-details/dog-breed-details.component';
import { AddDogBreedComponent } from './components/add-dog-breed/add-dog-breed.component';

const routes: Routes = [
  { path: '', redirectTo: 'DogBreed', pathMatch: 'full' },
  { path: 'DogBreed', component: DogBreedListComponent },
  { path: 'DogBreed/:id', component: DogBreedDetailsComponent },
  { path: 'add', component: AddDogBreedComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }