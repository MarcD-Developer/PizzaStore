import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PizzaHomePageComponent } from './pizza-home-page.component';

describe('PizzaHomePageComponent', () => {
  let component: PizzaHomePageComponent;
  let fixture: ComponentFixture<PizzaHomePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PizzaHomePageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PizzaHomePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
