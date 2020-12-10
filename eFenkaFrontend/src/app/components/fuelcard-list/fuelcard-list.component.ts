import {ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild} from '@angular/core';
import {Router} from '@angular/router';
import {FuelCard} from '../../models/fuel-card/fuel-card';
import {Person} from '../../models/person/person';
import {ApiService} from '../../services/api.service';
import {MdbTableDirective, MdbTablePaginationComponent} from 'angular-bootstrap-md';

@Component({
  selector: 'app-fuelcard-list',
  templateUrl: './fuelcard-list.component.html',
  styleUrls: ['./fuelcard-list.component.css']
})
export class FuelcardListComponent implements OnInit {
  ascDescBoolean: boolean;
  fuelCards: FuelCard[];

  headNames = ['Nummerplaat', 'Bestuurder', 'Leverancier', 'Brandstof', 'Startdatum', 'Einddatum'];
  headElements = ['vehicle.licensePlate:', 'driver.person', 'company.name', 'vehicle.fuelType.name', 'startDate', 'endDate'];

  @ViewChild(MdbTableDirective, {static: true}) mdbTable: MdbTableDirective;
  @ViewChild(MdbTablePaginationComponent, {static: true}) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild('row', {static: true}) row: ElementRef;

  searchText = '';
  previous: string;

  constructor(private router: Router, private apiService: ApiService, private cdRef: ChangeDetectorRef) {
  }

  ngOnInit(): void {
    this.apiService.getAllFuelCards().subscribe(data => {
      this.fuelCards = data;
      this.mdbTable.setDataSource(this.fuelCards);
      this.previous = this.mdbTable.getDataSource();
    });
  }

  ngAfterViewInit(): void {
    this.cdRef.detectChanges();
  }

  navigateToNewFuelCardComponent(): void {
    this.router.navigate(['/fuelcards/new']);
  }

  navigateToFuelCardDetailsComponent(index: number): void {
    this.router.navigate(['/fuelcards', index]);
  }

  searchItems(): void {
    const prev = this.mdbTable.getDataSource();
    if (!this.searchText) {
      this.mdbTable.setDataSource(this.previous);
      this.fuelCards = this.mdbTable.getDataSource();
    }
    if (this.searchText) {
      this.fuelCards = this.mdbTable.searchLocalDataBy(this.searchText);
      this.mdbTable.setDataSource(prev);
    }
  }

  getFullName(person: Person): string {
    return person.firstname + ' ' + person.lastname;
  }
}
