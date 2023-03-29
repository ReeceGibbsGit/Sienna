import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EspressoShotComponent } from './espresso-shot.component';

describe('EspressoShotComponent', () => {
  let component: EspressoShotComponent;
  let fixture: ComponentFixture<EspressoShotComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EspressoShotComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EspressoShotComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
