import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditcomponentComponent } from './editcomponent.component';

describe('EditcomponentComponent', () => {
  let component: EditcomponentComponent;
  let fixture: ComponentFixture<EditcomponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EditcomponentComponent]
    });
    fixture = TestBed.createComponent(EditcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
