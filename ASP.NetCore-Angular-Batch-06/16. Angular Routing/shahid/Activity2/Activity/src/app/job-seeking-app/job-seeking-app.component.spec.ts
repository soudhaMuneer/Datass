import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JobSeekingAppComponent } from './job-seeking-app.component';

describe('JobSeekingAppComponent', () => {
  let component: JobSeekingAppComponent;
  let fixture: ComponentFixture<JobSeekingAppComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [JobSeekingAppComponent]
    });
    fixture = TestBed.createComponent(JobSeekingAppComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
