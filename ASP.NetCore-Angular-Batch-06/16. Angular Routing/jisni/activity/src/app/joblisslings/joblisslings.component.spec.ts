import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JoblisslingsComponent } from './joblisslings.component';

describe('JoblisslingsComponent', () => {
  let component: JoblisslingsComponent;
  let fixture: ComponentFixture<JoblisslingsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [JoblisslingsComponent]
    });
    fixture = TestBed.createComponent(JoblisslingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
