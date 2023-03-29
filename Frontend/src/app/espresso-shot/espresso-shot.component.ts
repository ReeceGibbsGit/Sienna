import { Component } from '@angular/core';
import { EspressoShot } from '../models/espresso-shot';

// todo: this functionality needs to be extracted out to a service
enum Flavour {
  VeryAcidic = 1,
  SlightlyAcidic = 2,
  BalancedFlavour = 3,
  SlightlyBitter = 4,
  VeryBitter = 5
}

@Component({
  selector: 'app-espresso-shot',
  templateUrl: './espresso-shot.component.html',
  styleUrls: ['./espresso-shot.component.scss']
})
export class EspressoShotComponent {
  espressoShot: EspressoShot = {
    id: '1234',
    beanType: 'Avalanche Melt',
    grind: 1.2,
    beans: 15.0,
    pressure: 7.0,
    water: 88.0,
    brewTime: 47.0,
    flavour: 3,
    rating: 4.2,
    comments: 'Well balanced shot. Very pleasant.'
  }

  // todo: this functionality needs to be extracted out to a service
  getFlavourText = () => Flavour[this.espressoShot.flavour]
}
