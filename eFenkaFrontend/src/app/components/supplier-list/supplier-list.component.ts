import { ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { faCheck, faTimes } from '@fortawesome/free-solid-svg-icons';
import { MdbTableDirective, MdbTablePaginationComponent } from 'angular-bootstrap-md';
import { ApiService } from 'src/app/services/api.service';
import { Supplier } from '../../models/supplier/supplier';

@Component({
  selector: 'app-supplier-list',
  templateUrl: './supplier-list.component.html',
  styleUrls: ['./supplier-list.component.css']
})
export class SupplierListComponent implements OnInit {
  faCheck = faCheck;
  faTimes = faTimes;
  suppliers: Supplier[];
  headNames  = ['Naam', 'Actief', 'Intern'];
  headElements  = ['name', 'active', 'internal'];

  @ViewChild(MdbTableDirective, {static: true}) mdbTable: MdbTableDirective;
  @ViewChild(MdbTablePaginationComponent, {static: true}) mdbTablePagination: MdbTablePaginationComponent;
  @ViewChild('row', {static: true}) row: ElementRef;

  searchText = '';
  previous: string;
  maxVisibleItems = 3;

  constructor(private router: Router, private apiService: ApiService, private cdRef: ChangeDetectorRef) {
  }

  ngOnInit(): void {
    this.apiService.getAllSuppliers().subscribe(
      data => {
        this.suppliers = data;

        this.mdbTable.setDataSource(this.suppliers);
        this.suppliers = this.mdbTable.getDataSource();
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

  navigateToNewSupplierComponent(): void {
    this.router.navigate(['/suppliers/new']);
  }

  navigateToSupplierDetailsComponent(index: number): void {
    this.router.navigate(['/suppliers', index]);
  }

  searchItems(): void {
    const prev = this.mdbTable.getDataSource();
    if (!this.searchText) {
      this.mdbTable.setDataSource(this.previous);
      this.suppliers = this.mdbTable.getDataSource();
    }
    if (this.searchText) {
      this.suppliers = this.mdbTable.searchLocalDataBy(this.searchText);
      this.mdbTable.setDataSource(prev);
    }
  }
}
