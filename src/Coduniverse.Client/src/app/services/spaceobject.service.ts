import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from "../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class SpaceobjectService {
  url = environment.apiUrl + "spaceobject";
  constructor(private http: HttpClient) { }

  getSpaceObjects() {
    return this.http.get(this.url);
  }
}
