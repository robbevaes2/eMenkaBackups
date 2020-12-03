import {AfterViewInit, ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild} from '@angular/core';
import {Router} from '@angular/router';
import {Vehicle} from '../../models/vehicle/vehicle';
import {MdbTableDirective, MdbTablePaginationComponent} from 'angular-bootstrap-md';
import {ApiService} from '../../services/api.service';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrls: ['./vehicle-list.component.css']
})
export class VehicleListComponent implements OnInit, AfterViewInit {
  vehicles: Vehicle[];
  headNames  = ['Merk', 'Model', 'brandstof', 'type motor', 'aantal deuren', 'volume', 'fiscale Pk', 'vermogen', 'Einddatum'];
  headElements  = ['brand.name', 'model.name', 'fuelType.name', 'motorType.name', 'doorType.name', 'volume', 'fiscalHp', 'power', 'endDateDelivery'];

  @ViewChild(MdbTableDirective, {static: true}) mdbTable: MdbTableDirective;
  @ViewChild(MdbTablePaginationComponent, {static: true}) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild('row', {static: true}) row: ElementRef;

  searchText = '';
  previous: string;

  maxVisibleItems = 3;

  constructor(private router: Router, private apiService: ApiService, private cdRef: ChangeDetectorRef) {
  }

  ngOnInit(): void {
    this.apiService.getAllVehicles().subscribe(
      data => {
        this.vehicles = data;

        this.mdbTable.setDataSource(this.vehicles);
        this.vehicles = this.mdbTable.getDataSource();
        this.previous = this.mdbTable.getDataSource();
      }
    );
  }

  ngAfterViewInit(): void {


    /*
    this.mdbTablePagination.setMaxVisibleItemsNumberTo(this.maxVisibleItems);

    this.mdbTablePagination.calculateFirstItemIndex();
    this.mdbTablePagination.calculateLastItemIndex();
    */
    this.cdRef.detectChanges();
  }

  navigateToNewVehicleComponent(): void {
    this.router.navigate(['/vehicles/new']);
  }

  navigateToVehicleDetailsComponent(index: number): void {
    this.router.navigate(['/vehicles', index]);
  }

  searchItems(): void {
    const prev = this.mdbTable.getDataSource();
    if (!this.searchText) {
      this.mdbTable.setDataSource(this.previous);
      this.vehicles = this.mdbTable.getDataSource();
    }
    if (this.searchText) {
      this.vehicles = this.mdbTable.searchLocalDataBy(this.searchText);
      this.mdbTable.setDataSource(prev);
    }
  }
  dateToStringConverter(date: string): string {
    return new Date(date).toLocaleDateString();
  }
}
