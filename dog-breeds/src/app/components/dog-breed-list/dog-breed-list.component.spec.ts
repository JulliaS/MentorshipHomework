import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DogBreedListComponent } from './dog-breed-list.component';

describe('DogBreedListComponent', () => {
  let component: DogBreedListComponent;
  let fixture: ComponentFixture<DogBreedListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DogBreedListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DogBreedListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
