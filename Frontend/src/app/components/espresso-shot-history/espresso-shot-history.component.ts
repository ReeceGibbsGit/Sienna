import { Component } from '@angular/core';
import { EspressoShot } from 'src/app/models/espresso-shot';
import { EspressoShotService } from 'src/app/services/espresso-shot/espresso-shot.service';

@Component({
  selector: 'app-espresso-shot-history',
  templateUrl: './espresso-shot-history.component.html',
  styleUrls: ['./espresso-shot-history.component.scss']
})
export class EspressoShotHistoryComponent {
  espressoShots: EspressoShot[] = [];

  constructor(private espressoShotService: EspressoShotService) {}

  ngOnInit(): void {
    this.getEspressoShots();
  }

  getEspressoShots(): void {
    this.espressoShotService.getEspressoShots()
      .subscribe(espressoShots => this.espressoShots = espressoShots);
  }
}
