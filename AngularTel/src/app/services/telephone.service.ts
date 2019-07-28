import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Telephone } from '../models/telephone';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TelephoneService {

  APIUrl = 'http://localhost:58445/api/telephone';

  constructor(private http: HttpClient) {}

  getTelephones(): Observable<Telephone[]> {
    return this.http.get<Telephone[]>(this.APIUrl);
  }

  getTelephone(id: number): Observable<Telephone> {
    return this.http.get<Telephone>(this.APIUrl + '/' + id);
  }
}
