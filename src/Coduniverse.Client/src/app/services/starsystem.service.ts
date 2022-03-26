import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from "../../environments/environment";
import { StarSystem } from '../models/star-system';

@Injectable({
  providedIn: 'root'
})
export class StarSystemService {
  url = environment.apiUrl + "/starsystem";
  constructor(private http: HttpClient) { }

  getStarSystems() {
    return this.http.get<StarSystem[]>(this.url);
  }
}
