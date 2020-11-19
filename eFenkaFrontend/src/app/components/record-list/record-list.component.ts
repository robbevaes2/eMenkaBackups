import { Record } from './../../models/record/record';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-record-list',
  templateUrl: './record-list.component.html',
  styleUrls: ['./record-list.component.css']
})
export class RecordListComponent implements OnInit {
  records: Record[];
  pageAmounts = [5,10,25];

  page = 1;
  selectedAmount = 5;
  pageSize;


  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  navigateToNewRecordComponent(): void {
    this.router.navigate(['/records/new']);
  }

  navigateToRecordDetailsComponent(index: number): void {
    this.router.navigate(['/records', index]);
  }

  switchPage(event): void {
    this.page = event;
  }

  handlePageSizeChange(event): void {
    this.pageSize = event.target.value;
    this.page = 1;
    console.log(this.selectedAmount);
    console.log(this.pageSize);
  }
}
