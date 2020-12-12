import { Component, OnInit } from '@angular/core';
import { DogBreedService } from 'src/app/services/dog-breed.service';
import { ActivatedRoute, Router } from '@angular/router';
import { DogBreed } from 'src/app/dog-breed';

@Component({
  selector: 'app-dog-breed-details',
  templateUrl: './dog-breed-details.component.html',
  styleUrls: ['./dog-breed-details.component.css']
})
export class DogBreedDetailsComponent implements OnInit {
  currentDogBreed : DogBreed;
  message = '';
  updated = false;

  constructor(
    private dogBreedService: DogBreedService,
    private route: ActivatedRoute,
    private router: Router) {
      this.currentDogBreed = null as any;
     }

  ngOnInit(): void {
    this.message = '';
    this.getDogBreed(this.route.snapshot.paramMap.get('id') as unknown as number);
  }

  getDogBreed(id : number): void {
    this.dogBreedService.getById(id)
      .subscribe(
        data => {
          this.currentDogBreed = data;
          this.updated = false;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

  updateDogBreed(): void {
    this.dogBreedService.update(this.currentDogBreed.id, this.currentDogBreed)
      .subscribe(
        response => {
          console.log(response);
          this.updated = true;
          this.message = 'The Dog Breed was updated successfully!';
        },
        error => {
          console.log(error);
        });
  }

  getCurrentDogBreed(dogBreed : DogBreed): void {
    this.updated = false;
    this.currentDogBreed = dogBreed;
    this.router.navigate([`/DogBreed/${this.currentDogBreed.id}`]);
  }
}
