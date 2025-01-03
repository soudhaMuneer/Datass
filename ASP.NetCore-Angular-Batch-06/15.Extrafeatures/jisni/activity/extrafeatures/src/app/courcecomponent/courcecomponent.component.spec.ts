import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CourcecomponentComponent } from './courcecomponent.component';

describe('CourcecomponentComponent', () => {
  let component: CourcecomponentComponent;
  let fixture: ComponentFixture<CourcecomponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CourcecomponentComponent]
    });
    fixture = TestBed.createComponent(CourcecomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
