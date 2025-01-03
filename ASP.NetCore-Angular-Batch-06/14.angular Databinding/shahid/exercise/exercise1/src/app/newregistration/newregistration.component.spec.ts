import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewregistrationComponent } from './newregistration.component';

describe('NewregistrationComponent', () => {
  let component: NewregistrationComponent;
  let fixture: ComponentFixture<NewregistrationComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NewregistrationComponent]
    });
    fixture = TestBed.createComponent(NewregistrationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
