import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EspressoShotFormComponent } from './espresso-shot-form.component';

describe('EspressoShotFormComponent', () => {
  let component: EspressoShotFormComponent;
  let fixture: ComponentFixture<EspressoShotFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EspressoShotFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EspressoShotFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
