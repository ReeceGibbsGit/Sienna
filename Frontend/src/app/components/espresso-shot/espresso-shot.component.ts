import { Component, Input } from '@angular/core';
import { EspressoShot, Flavour } from '../../models/espresso-shot';

@Component({
  selector: 'app-espresso-shot',
  templateUrl: './espresso-shot.component.html',
  styleUrls: ['./espresso-shot.component.scss']
})
export class EspressoShotComponent {
  @Input() espressoShot: EspressoShot = {
    id: '',
    beanType: '',
    grind: 0.0,
    beans: 0.0,
    pressure: 0.0,
    water: 0.0,
    brewTime: 0.0,
    flavour: 1,
    rating: 1,
    comments: ''
};

  // todo: we definitely should not have to do this. Change the API to return the proper value
  getFlavourText = () => Flavour[this.espressoShot.flavour]
}
