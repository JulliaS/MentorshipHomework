import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DogBreedDetailsComponent } from './dog-breed-details.component';

describe('DogBreedDetailsComponent', () => {
  let component: DogBreedDetailsComponent;
  let fixture: ComponentFixture<DogBreedDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DogBreedDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DogBreedDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
