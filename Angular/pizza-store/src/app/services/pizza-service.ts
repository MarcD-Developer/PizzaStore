import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Pizza } from '../Models/pizza';

@Injectable()
export class PizzaService {
  constructor(private http: HttpClient) { }

  configUrl = 'http://localhost:51539/api/pizza';

  getPizza() {
    // now returns an Observable of Pizza
    return this.http.get<Pizza>(this.configUrl);
  }
}