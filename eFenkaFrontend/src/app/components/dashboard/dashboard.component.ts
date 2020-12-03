import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Vehicle } from '../../models/vehicle/vehicle';
import { MdbTableDirective, MdbTablePaginationComponent } from 'angular-bootstrap-md';
import { ApiService } from '../../services/api.service';
import { Serie } from 'src/app/models/serie/serie';
import { ChartsModule, WavesModule } from 'angular-bootstrap-md'

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  vehicles: Vehicle[];
  public dataArray: Array<number> = [];

  //pie chart
  public chartType: string = 'pie';


  public chartDatasets: Array<any> = [{
    data: this.dataArray,
    label: "test"
  }];

  public chartLabels: Array<any> = [];

  public chartColors: Array<any> = [
    {
      backgroundColor: [],
      borderWidth: 2,
    }
  ];

  public chartOptions: any = {
    responsive: true
  };

  // bar chart
  public categoryChartType: string = 'bar';

  public categoryChartDatasets: Array<any> = [{
    data: this.dataArray,
    label: "test"
  }];

  public categoryChartLabels: Array<any> = [];

  public categoryChartColors: Array<any> = [
    {
      backgroundColor: [],
      borderWidth: 2,
    }
  ];

  public categoryChartOptions: any = {
    responsive: true,
    scales: {
      yAxes: [{
        ticks: {
          beginAtZero: true
        }
      }]
    }
  };

  public chartClicked(e: any): void { }
  public chartHovered(e: any): void { }

  constructor(private router: Router, private apiService: ApiService, private cdRef: ChangeDetectorRef) { }

  ngOnInit(): void {

    this.apiService.getAllVehicles().subscribe(
      data => {
        this.vehicles = data;

        this.apiService.getAllBrands().subscribe(
          data => {
            data.forEach(element => {
              this.chartLabels.push(element.name);
            });
        
            this.chartLabels.forEach(element => {
              let test = this.vehicles.filter((b) => (b.brand.name === element)).length;

              if(test > 0) {
                this.dataArray.push(test);
              }
              //this.dataArray.push(this.vehicles.filter((b) => (b.brand.name === element)).length);
            });
    
            this.chartDatasets = [{
              data: this.dataArray,
              label: "Aantal voertuigen per merk"
            }]
    
            this.chartLabels.forEach(element => {
              this.chartColors[0].backgroundColor.push(this.getRandomColor());
            });
          }
        )   
        
        this.apiService.getAllCategories().subscribe(
          data => {
            data.forEach(element => {
              this.categoryChartLabels.push(element.name)
            });
        
            this.categoryChartLabels.forEach(element => {
              this.dataArray.push(this.vehicles.filter((b) => (b.category.name === element)).length);
            });
    
            this.categoryChartDatasets = [{
              data: this.dataArray,
              label: "Aantal voertuigen per categorie"
            }]
    
            this.categoryChartLabels.forEach(element => {
              this.chartColors[0].backgroundColor.push(this.getRandomColor());
            });
          }
        )
      }
    )
  }

  getRandomColor() {
    var color = Math.floor(0x1000000 * Math.random()).toString(16);
    return '#' + ('000000' + color).slice(-6);
  }

}
