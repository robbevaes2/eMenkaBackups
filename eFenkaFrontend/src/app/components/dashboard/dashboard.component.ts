import { ChangeDetectorRef, Component, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Vehicle } from '../../models/vehicle/vehicle';
import { MdbTableDirective, MdbTablePaginationComponent } from 'angular-bootstrap-md';
import { ApiService } from '../../services/api.service';
import { Serie } from 'src/app/models/serie/serie';
import { ChartsModule, WavesModule } from 'angular-bootstrap-md'
import { DashboardModelChartComponent } from '../dashboard-model-chart/dashboard-model-chart/dashboard-model-chart.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private router: Router, private apiService: ApiService, private cdRef: ChangeDetectorRef) { }

  ngOnInit(): void { }

}
