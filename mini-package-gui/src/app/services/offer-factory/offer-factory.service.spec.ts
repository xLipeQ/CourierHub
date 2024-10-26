import { TestBed } from '@angular/core/testing';

import { OfferFactoryService } from './offer-factory.service';

describe('OfferFactoryService', () => {
  let service: OfferFactoryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OfferFactoryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
