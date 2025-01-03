import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContentComponent } from './content.component';

describe('ContentComponent', () => {
  let component: ContentComponent;
  let fixture: ComponentFixture<ContentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ContentComponent]
    });
    fixture = TestBed.createComponent(ContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it(`should have as title 'content'`,() => {
    const fixture = TestBed.createComponent(ContentComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('content');
  });

  it('should initialize properties correctly', () => {
fixture.detectChanges();
expect(component.someData).toEqual('Test Data');
  });

  it('should render template elements', () => {
    fixture.detectChanges();
    const compiled = fixture.nativeElement;
    expect(compiled.querySelector('h2')).toBeTruthy(); // Check if an h element exists
    expect(compiled.querySelector('.findjobseeker')).toBeTruthy(); // Check if an h1 element exists
    
  });

  
});

