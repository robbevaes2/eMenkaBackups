import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Model } from 'src/app/models/model/model';
import { Vehicle } from 'src/app/models/vehicle/vehicle';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-dashboard-model-chart',
  templateUrl: './dashboard-model-chart.component.html'
})
export class DashboardModelChartComponent implements OnInit {
  vehicles: Vehicle[];
  models: Model[];

  public dataArray: Array<any> = [];

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

  constructor(private route: ActivatedRoute, private router: Router, private apiService: ApiService, private cdRef: ChangeDetectorRef) { }

  ngOnInit(): void {
    const index = this.route.snapshot.params.index;

    this.apiService.getAllVehiclesByBrandId(index).subscribe(
      brandData => {
        this.vehicles = brandData;

        this.dataArray = [];

        this.vehicles.forEach(i => {
          let test = this.vehicles.filter((m) => (m.model.id === i.model.id));

          //this.dataArray.push(test);

          if (this.chartLabels.length > 0) {
            
            let labelCount  = this.chartLabels.find((m) => (m === test[0].model.name))

            //let labelCount = this.chartLabels.filter((m) => (m.model.id === test[0].model.id)).length;

            if (labelCount === undefined) {
              this.chartLabels.push(test[0].model.name);
            }
          } else {
            this.chartLabels.push(test[0].model.name);
          }
        });

        this.chartLabels.forEach(i => {
          this.dataArray.push(this.vehicles.filter((m) => (m.model.name === i)).length);
        });

        this.chartDatasets = [{
          data: this.dataArray,
          label: "Aantal voertuigen per model"
        }];
        

        /*
        this.apiService.getAllBrands().subscribe(
          brandData => {
            this.dataArray = [];

            let brandVehicles = this.vehicles.filter((b) => (b.brand.name === this.chartLabels[index]));

            brandVehicles.forEach(i => {
              let labels = this.vehicles.filter((b) => (b.model.name === i.model.name)).length

              if(labels > 0) {
              this.chartLabels.push(i.model.name);
              }   
            });

            this.chartLabels.forEach(i => {
              this.dataArray.push(this.vehicles.filter((b) => (b.brand.name === i)).length);
            });

            this.chartDatasets = [{
              data: this.dataArray,
              label: "Aantal voertuigen per merk"
            }];
          }) 
          */
      })  
  }

  public chartClicked(e: any): void { }

  public chartHovered(e: any): void { }

}
