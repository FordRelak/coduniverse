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

  getStarSystem(id: string) {
    return this.http.get<any>(this.url + `/${id}`);
  }

  makeCenterMass(data: any) {
    return this.http.post(this.url + '/centermass', data);
  }

  addOrUpdate(data: any) {
    if (data.id == null) {
      return this.http.post(this.url, data);
    }
    else {
      return this.http.put(this.url, data);
    }
  }
  delete(id: string) {
    return this.http.delete(this.url + `/${id}`);
  }
}
