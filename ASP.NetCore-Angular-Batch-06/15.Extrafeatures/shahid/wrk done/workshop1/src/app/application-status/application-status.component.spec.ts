import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicationStatusComponent } from './application-status.component';

describe('ApplicationStatusComponent', () => {
  let component: ApplicationStatusComponent;
  let fixture: ComponentFixture<ApplicationStatusComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ApplicationStatusComponent]
    });
    fixture = TestBed.createComponent(ApplicationStatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
