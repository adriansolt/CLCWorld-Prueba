import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TelephoneDetailsComponent } from './telephone-details.component';

describe('TelephoneDetailsComponent', () => {
  let component: TelephoneDetailsComponent;
  let fixture: ComponentFixture<TelephoneDetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TelephoneDetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TelephoneDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
