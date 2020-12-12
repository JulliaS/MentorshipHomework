import { Component, OnInit } from '@angular/core';
import { DogBreedService } from 'src/app/services/dog-breed.service';
import {DogBreed} from '../../dog-breed'

@Component({
  selector: 'app-add-dog-breed',
  templateUrl: './add-dog-breed.component.html',
  styleUrls: ['./add-dog-breed.component.css']
})
export class AddDogBreedComponent implements OnInit {
  dogBreed : DogBreed;
  submitted = false;

  constructor(private dogBreedService: DogBreedService) {
    this.dogBreed = this.emptyDogBreed();
   }

  ngOnInit(): void {
  }

  saveDogBreed(): void {
    const data : DogBreed = {
      id : this.dogBreed.id,
      breed : this.dogBreed.breed,
      country :  this.dogBreed.country,
      averageAge : this.dogBreed.averageAge,
      averageWeight : this.dogBreed.averageWeight,
      unitOfWeight : this.dogBreed.unitOfWeight,
      averageHeight : this.dogBreed.averageHeight,
      unitOfHeight : this.dogBreed.unitOfHeight,
      hairLenght : this.dogBreed.hairLenght,
      averagePrice : this.dogBreed.averagePrice,
      unitOfPrice : this.dogBreed.unitOfPrice,
      picture : this.dogBreed.picture
    };

    this.dogBreedService.create(data)
      .subscribe(
        response => {
          console.log(response);
          this.submitted = true;
        },
        error => {
          console.log(error);
        });
  }

  emptyDogBreed(): DogBreed {
    return {
      id : 0,
      breed : '',
      country : '',
      averageAge : 0,
      averageWeight : 0,
      unitOfWeight : '',
      averageHeight : 0,
      unitOfHeight : '',
      hairLenght : '',
      averagePrice : 0,
      unitOfPrice : '',
      picture : ''
    };
  }

  newDogBreed(): void {
    this.submitted = false;
    this.dogBreed = this.emptyDogBreed();
  }
}
