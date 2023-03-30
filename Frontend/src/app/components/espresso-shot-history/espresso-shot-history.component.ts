import { Component, Input } from '@angular/core';
import { EspressoShot } from 'src/app/models/espresso-shot';

@Component({
  selector: 'app-espresso-shot-history',
  templateUrl: './espresso-shot-history.component.html',
  styleUrls: ['./espresso-shot-history.component.scss']
})
export class EspressoShotHistoryComponent {
  @Input() espressoShots: EspressoShot[] = [];
}
