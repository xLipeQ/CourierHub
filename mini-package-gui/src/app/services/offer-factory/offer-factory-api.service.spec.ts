import { TestBed } from '@angular/core/testing';

import { OfferFactoryApiService } from './offer-factory-api.service';

describe('OfferFactoryApiService', () => {
  let service: OfferFactoryApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OfferFactoryApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
