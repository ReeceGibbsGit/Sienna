import { TestBed } from '@angular/core/testing';

import { EspressoShotService } from './espresso-shot.service';

describe('EspressoShotService', () => {
  let service: EspressoShotService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EspressoShotService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
