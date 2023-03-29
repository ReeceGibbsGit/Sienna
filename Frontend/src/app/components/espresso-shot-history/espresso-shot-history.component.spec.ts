import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EspressoShotHistoryComponent } from './espresso-shot-history.component';

describe('EspressoShotHistoryComponent', () => {
  let component: EspressoShotHistoryComponent;
  let fixture: ComponentFixture<EspressoShotHistoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EspressoShotHistoryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EspressoShotHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
