import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddDogBreedComponent } from './add-dog-breed.component';

describe('AddDogBreedComponent', () => {
  let component: AddDogBreedComponent;
  let fixture: ComponentFixture<AddDogBreedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddDogBreedComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddDogBreedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
