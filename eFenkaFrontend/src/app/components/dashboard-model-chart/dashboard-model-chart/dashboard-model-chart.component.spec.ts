import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardModelChartComponent } from './dashboard-model-chart.component';

describe('DashboardModelChartComponent', () => {
  let component: DashboardModelChartComponent;
  let fixture: ComponentFixture<DashboardModelChartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DashboardModelChartComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DashboardModelChartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
