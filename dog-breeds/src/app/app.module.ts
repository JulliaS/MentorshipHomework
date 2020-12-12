import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
 import { DogBreedListComponent } from './components/dog-breed-list/dog-breed-list.component';
 import { AddDogBreedComponent } from './components/add-dog-breed/add-dog-breed.component';
 import { DogBreedDetailsComponent } from './components/dog-breed-details/dog-breed-details.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatToolbarModule} from '@angular/material/toolbar';
import { MatIconModule} from '@angular/material/icon';
import { MatCardModule} from '@angular/material/card';
import { MatButtonModule} from '@angular/material/button';
import { MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import { arLocale } from 'ngx-bootstrap/locale';
import { from } from 'rxjs';

@NgModule({
  declarations: [
    AppComponent,
     DogBreedListComponent,
     AddDogBreedComponent,
     DogBreedDetailsComponent
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatCardModule,
    MatProgressSpinnerModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
