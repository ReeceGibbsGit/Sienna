import { Injectable } from '@angular/core';
import { Observable, catchError, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

// todo: update the way we handle vars like this
import config from '../../../assets/config.json';
import { EspressoShot } from 'src/app/models/espresso-shot';
import { EspressoShotDto } from './../../models/espresso-shot';

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

  createEspressoShot(espressoShot: EspressoShotDto): Observable<EspressoShot> {
    return this.http.post<EspressoShot>(this.apiUrl, espressoShot, this.httpOptions)
      .pipe(
        catchError(error => {
          console.log(error);
          return of(error);
        })
      );
  }
}
