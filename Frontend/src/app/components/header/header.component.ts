import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
  header = 'Sienna';
  logoPath = '../../assets/logo/sienna-text.png';
  iconPath = '../../assets/icons/icon-128x128.png'
}
