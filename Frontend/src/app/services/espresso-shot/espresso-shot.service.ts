import { Injectable } from '@angular/core';
import { EspressoShot } from '../../models/espresso-shot';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

// todo: update the way we handle vars like this
import config from '../../../assets/config.json';

const baseUrl: string = config.apiBaseUrl ?? '';
const apiKey: string = config.apiKey ?? '';

@Injectable({
  providedIn: 'root'
})
export class EspressoShotService {
  private apiUrl = `${baseUrl}/api/espressoshots`;

  private httpOptions = {
    headers: new HttpHeaders({
      'X-API-Key': apiKey,
    })
  };

  constructor(private http: HttpClient) { }

  getEspressoShots(): Observable<EspressoShot[]> {
    return this.http.get<EspressoShot[]>(this.apiUrl, this.httpOptions);
  }
}
