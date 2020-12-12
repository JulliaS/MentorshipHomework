import { Component, OnInit } from '@angular/core';
import { DogBreed } from 'src/app/dog-breed';
import { DogBreedService } from 'src/app/services/dog-breed.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-dog-breed-list',
  templateUrl: './dog-breed-list.component.html',
  styleUrls: ['./dog-breed-list.component.css']
})
export class DogBreedListComponent implements OnInit {

  dogBreeds : DogBreed[];
  currentDogBreed : DogBreed;
  detailed = false;

  constructor(
    private dogBreedService: DogBreedService,
    private router: Router) {
    this.dogBreeds = [];
    this.currentDogBreed = null as any;
   }

  ngOnInit(): void {
    this.retrieveDogBreeds();
  }

  retrieveDogBreeds(): void {
    this.detailed = false;
    this.dogBreedService.getAll()
      .subscribe(
        (data : DogBreed[]) => {
          this.dogBreeds = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

  refreshList(): void {
    this.retrieveDogBreeds();
    this.currentDogBreed = null as any;
  }

  setActiveDogBreed(dogBreed : DogBreed): void {
    this.detailed = true;
    this.currentDogBreed = dogBreed;
  }

  deleteDogBreed(): void {
    this.dogBreedService.delete(this.currentDogBreed.id)
      .subscribe(
        response => {
          console.log(response);
          this.refreshList();
          this.router.navigate(['/DogBreed']);
        },
        error => {
          console.log(error);
        });
  }
}
