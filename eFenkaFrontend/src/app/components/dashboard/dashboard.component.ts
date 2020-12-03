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

  // pie chart
  public chartType: string = 'pie';


  public chartDatasets: Array<any> = [{
    data: this.dataArray,
    label: "test"
  }];

  public chartLabels: Array<any> = [];

  public chartColors: Array<any> = [
    {
      backgroundColor: [
        '#FF6633', '#FFB399', '#FF33FF', '#FFFF99', '#80B300',
        '#00B3E6', '#E6B333', '#3366E6', '#999966', '#99FF99',  
        '#809900', '#E6B3B3', '#6680B3', '#66991A', '#B34D4D',
        '#FF1A66', '#E6331A', '#33FFCC', '#FF99E6', '#CCFF1A',
        '#66994D', '#B366CC', '#4D8000', '#B33300', '#CC80CC',     
		    '#66664D', '#991AFF', '#E666FF', '#4DB3FF', '#1AB399',
        '#E666B3', '#33991A', '#CC9999', '#B3B31A', '#00E680', 
        '#4D8066', '#809980', '#E6FF80', '#1AFF33', '#999933',
        '#FF3380', '#CCCC00', '#66E64D', '#4D80CC', '#9900B3', 
        '#E64D66', '#4DB380', '#FF4D4D', '#99E6E6', '#6666FF'],
      borderWidth: 2,
    }
  ];

  public chartOptions: any = {
    responsive: true
  };

  // category bar chart
  public categoryChartType: string = 'bar';

  public categoryChartDatasets: Array<any> = [{
    data: this.dataArray,
    label: "test"
  }];

  public categoryChartLabels: Array<any> = [];

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
          brandData => {
            this.dataArray = [];

            brandData.forEach(i => {
              let test = this.vehicles.filter((b) => (b.brand.name === i.name)).length
              
              if(test > 0) {
                this.chartLabels.push(i.name);
              }             
            });
        
            this.chartLabels.forEach(i => {
              this.dataArray.push(this.vehicles.filter((b) => (b.brand.name === i)).length);
            });
    
            this.chartDatasets = [{
              data: this.dataArray,
              label: "Aantal voertuigen per merk"
            }]
    
            /*
            this.chartLabels.forEach(element => {
              this.chartColors[0].backgroundColor.push(this.getRandomColor());
            })*/
            ;
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