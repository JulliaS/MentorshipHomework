import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DogBreed } from '../dog-breed';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DogBreedService {

  private REST_API_SERVER = "https://localhost:44302/api/DogBreed";

  constructor(private httpClient: HttpClient) { }

  public getAll(): Observable<DogBreed[]> {
    return this.httpClient.get<DogBreed[]>(this.REST_API_SERVER);
  }

  public getById(id: number): Observable<DogBreed> {
    return this.httpClient.get<DogBreed>(`${this.REST_API_SERVER}/${id}`);
  }

  create(data: DogBreed): Observable<DogBreed> {
    return this.httpClient.post<DogBreed>(this.REST_API_SERVER, data);
  }

  update(id: number, data: DogBreed): Observable<DogBreed> {
    return this.httpClient.put<DogBreed>(`${this.REST_API_SERVER}/${id}`, data);
  }

  delete(id: number): Observable<any> {
    return this.httpClient.delete(`${this.REST_API_SERVER}/${id}`);
  }
}