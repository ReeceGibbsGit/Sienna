import { Component, Output, EventEmitter } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { EspressoShotFormComponent } from '../espresso-shot-form/espresso-shot-form/espresso-shot-form.component';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
  header = 'Sienna';
  logoPath = '../../assets/logo/sienna-text.png';
  iconPath = '../../assets/icons/icon-128x128.png'

  @Output() closeEvent = new EventEmitter();

  constructor(private dialog: MatDialog) { }

  openEspressoShotDialog() {
    const dialogConfig = new MatDialogConfig();

    /**
     * All of our dialog config for our espresso shot form will go here
     */
    dialogConfig.autoFocus = true;

    dialogConfig.maxWidth = '80vw';
    dialogConfig.width = '80vw'

    dialogConfig.maxHeight = 'fit-content'
    dialogConfig.height = 'fit-content';

    const dialogRef = this.dialog.open(EspressoShotFormComponent, dialogConfig);

    dialogRef.afterClosed().subscribe(formData => 
      this.closeEvent.emit(formData)
    );
  }
}
