import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Spaceobject } from '../models/spaceobject';

@Injectable({
  providedIn: 'root'
})
export class SpaceObjectService {
  url = environment.apiUrl + "/spaceobject";
  constructor(private http: HttpClient) { }

  getSpaceObject(id: string) {
    return this.http.get<Spaceobject>(this.url + `/${id}`);
  }

  addOrUpdate(data: Spaceobject) {
    if (data.id == null && data.starSystemId != null) {
      return this.http.post(this.url, data);
    }
    else if (data.id != null && data.starSystemId != null) {
      return this.http.put(this.url, data);
    }
    return null;
  }

  delete(id: string) {
    return this.http.delete(this.url + `/${id}`);
  }
}
