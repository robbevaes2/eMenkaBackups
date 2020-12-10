import { AfterViewInit, ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { MdbTableDirective, MdbTablePaginationComponent } from 'angular-bootstrap-md';
import { Driver } from 'src/app/models/driver/driver';
import { ApiService } from 'src/app/services/api.service';
import { Language } from '../../enums/language/language.enum';
import { faCheck, faTimes } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-driver-list',
  templateUrl: './driver-list.component.html',
  styleUrls: ['./driver-list.component.css']
})
export class DriverListComponent implements OnInit, AfterViewInit {
  faCheck = faCheck;
  faTimes = faTimes;
  drivers: Driver[];
  headNames  = ['Voornaam', 'Naam', 'Rijbewijs categorie', 'Rijbewijs nummer', 'Taal', 'Actief'];
  headElements  = ['driver.person.firstname', 'driver.person.lastname', 'driver.person.driversLicenseType', 'driver.person.driversLicenseNumber', 'getLanguageName(driver.person.language)', 'isDriverActive(driver)'];

  @ViewChild(MdbTableDirective, { static: true }) mdbTable: MdbTableDirective;
  @ViewChild(MdbTablePaginationComponent, { static: true }) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild('row', { static: true }) row: ElementRef;

  searchText = '';
  previous: string;

  maxVisibleItems = 3;

  constructor(private router: Router, private apiService: ApiService, private cdRef: ChangeDetectorRef) { }

  ngOnInit(): void {
    this.apiService.getAllDrivers().subscribe(data => {
        this.drivers = data;
        this.mdbTable.setDataSource(this.drivers);
        this.previous = this.mdbTable.getDataSource();
      }
    );
  }

  ngAfterViewInit(): void {
    this.cdRef.detectChanges();
  }

  navigateToNewDriverComponent(): void {
    this.router.navigate(['/drivers/new']);
  }

  navigateToDriverDetailsComponent(index: number): void {
    this.router.navigate(['/drivers', index]);
  }

  isDriverActive(driver: Driver): boolean {
    const currentDate = new Date();
    const driverStartDate = new Date(driver.startDate);
    const driverEndDate = new Date(driver.endDate);

    return driverStartDate < currentDate && driverEndDate > currentDate;
  }

  getLanguageName(languageId: number): string {
    return Language[languageId];
  }

  searchItems(): void {
    const prev = this.mdbTable.getDataSource();
    if (!this.searchText) {
        this.mdbTable.setDataSource(this.previous);
        this.drivers = this.mdbTable.getDataSource();
    }
    if (this.searchText) {
        this.drivers = this.mdbTable.searchLocalDataBy(this.searchText);
        this.mdbTable.setDataSource(prev);
    }
  }
}
