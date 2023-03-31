import { Component } from '@angular/core';
import { EspressoShot } from './models/espresso-shot';
import { EspressoShotService } from './services/espresso-shot/espresso-shot.service';
import { EspressoShotDto } from './models/espresso-shot';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'sienna';
  espressoShots: EspressoShot[] = [];

  constructor(private espressoShotService: EspressoShotService) {}

  ngOnInit(): void {
    this.getEspressoShots();
  }

  handleClose(event: any) {
    if (event != undefined) {
      this.createEspressoShot(event);
    }
  }

  getEspressoShots(): void {
    this.espressoShotService.getEspressoShots()
      .subscribe(espressoShots => this.espressoShots = espressoShots);
  }

  createEspressoShot(espressoShotDto: EspressoShotDto) {
    this.espressoShotService.createEspressoShot(espressoShotDto)
      .subscribe(result => {
        this.espressoShots.unshift(result);
      });
  }
}
