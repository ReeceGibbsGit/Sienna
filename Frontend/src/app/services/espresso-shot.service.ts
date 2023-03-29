import { Injectable } from '@angular/core';
import { EspressoShot } from '../models/espresso-shot';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EspressoShotService {
  private apiUrl = 'http://192.168.1.63:7500/api/espressoshots';
  
  private httpOptions = {
    headers: new HttpHeaders({
      'X-API-Key': '',
    })
  };

  constructor(
    private http: HttpClient,
  ) { }

  getEspressoShots(): Observable<EspressoShot[]> {
    return this.http.get<EspressoShot[]>(this.apiUrl, this.httpOptions);
  }
}
