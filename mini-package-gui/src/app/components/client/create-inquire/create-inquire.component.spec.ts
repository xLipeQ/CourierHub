import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateInquireComponent } from './create-inquire.component';

describe('CreateInquireComponent', () => {
  let component: CreateInquireComponent;
  let fixture: ComponentFixture<CreateInquireComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CreateInquireComponent]
    });
    fixture = TestBed.createComponent(CreateInquireComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
