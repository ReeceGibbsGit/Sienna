import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-espresso-shot-form',
  templateUrl: './espresso-shot-form.component.html',
  styleUrls: ['./espresso-shot-form.component.scss']
})
export class EspressoShotFormComponent {
  form!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private dialogRef: MatDialogRef<EspressoShotFormComponent>
  ) { }

  save() {
    this.dialogRef.close(this.form.value);
  }

  ngOnInit() {
    this.form = this.formBuilder.group({
      id: '',
      beanType: '',
      grind: 0.0,
      beans: 0.0,
      pressure: 0.0,
      water: 0.0,
      brewTime: 0.0,
      flavour: 3,
      rating: 1,
      comments: ''
    })
  }
}
