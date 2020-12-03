import {Record} from '../../models/record/record';
import {AfterViewInit, ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild} from '@angular/core';
import {Router} from '@angular/router';
import {MdbTableDirective, MdbTablePaginationComponent} from 'angular-bootstrap-md';
import {ApiService} from 'src/app/services/api.service';

@Component({
  selector: 'app-record-list',
  templateUrl: './record-list.component.html',
  styleUrls: ['./record-list.component.css']
})
export class RecordListComponent implements OnInit, AfterViewInit {
  records: Record[];

  headNames: string[];
  headElements = ['fuelCard.vehicle.licensePlate', 'fuelCard.driver.person.firstname', 'corporation.name', 'costAllocatoin.name', 'fuelCard.vehicle.brand.name', 'fuelCard.vehicle.model.name', 'usage', 'fuelCard.vehicle.fuelType.name', 'startDate', 'endDate'];

  @ViewChild(MdbTableDirective, {static: true}) mdbTable: MdbTableDirective;
  @ViewChild(MdbTablePaginationComponent, {static: true}) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild('row', {static: true}) row: ElementRef;


  searchText = '';
  previous: string;

  constructor(private router: Router, private cdRef: ChangeDetectorRef, private apiService: ApiService) {
  }

  ngOnInit(): void {
    this.headNames = ['Nummerplaat', 'Bestuurder', 'Vennootschap', 'Kostenplaats', 'Merk', 'Wagen', 'Gebruik', 'Brandstof', 'Eerste Registratie', 'Eind Datum'];

    this.apiService.getAllRecords().subscribe(data => {
      this.records = data;

      this.mdbTable.setDataSource(this.records);
      this.records = this.mdbTable.getDataSource();
      this.previous = this.mdbTable.getDataSource();
    });
  }

  ngAfterViewInit(): void {
    // this.mdbTablePagination.setMaxVisibleItemsNumberTo(this.maxVisibleItems);

    // this.mdbTablePagination.calculateFirstItemIndex();
    // this.mdbTablePagination.calculateLastItemIndex();

    this.cdRef.detectChanges();
  }

  navigateToNewRecordComponent(): void {
    this.router.navigate(['/records/new']);
  }

  searchItems(): void {
    const prev = this.mdbTable.getDataSource();
    if (!this.searchText) {
      this.mdbTable.setDataSource(this.previous);
      this.records = this.mdbTable.getDataSource();
    }
    if (this.searchText) {
      this.records = this.mdbTable.searchLocalDataBy(this.searchText);
      this.mdbTable.setDataSource(prev);
    }
  }

  navigateToRecordDetailsComponent(index: number): void {
    this.router.navigate(['/records', index]);
  }
}
