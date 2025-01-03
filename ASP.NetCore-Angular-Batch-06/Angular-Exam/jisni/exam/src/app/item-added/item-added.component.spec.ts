import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemAddedComponent } from './item-added.component';

describe('ItemAddedComponent', () => {
  let component: ItemAddedComponent;
  let fixture: ComponentFixture<ItemAddedComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ItemAddedComponent]
    });
    fixture = TestBed.createComponent(ItemAddedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
