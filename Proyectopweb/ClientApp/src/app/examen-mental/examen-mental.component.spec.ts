import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ExamenMentalComponent } from './examen-mental.component';

describe('ExamenMentalComponent', () => {
  let component: ExamenMentalComponent;
  let fixture: ComponentFixture<ExamenMentalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ExamenMentalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExamenMentalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
