import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FootrComponent } from './footr.component';

describe('FootrComponent', () => {
  let component: FootrComponent;
  let fixture: ComponentFixture<FootrComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FootrComponent]
    });
    fixture = TestBed.createComponent(FootrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
