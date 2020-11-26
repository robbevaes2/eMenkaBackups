import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';
import {FuelCard} from '../../models/fuel-card/fuel-card';
import {FuelCardService} from '../../services/fuelcard-service';
import {Person} from '../../models/person/person';

@Component({
  selector: 'app-fuelcard-list',
  templateUrl: './fuelcard-list.component.html',
  styleUrls: ['./fuelcard-list.component.css']
})
export class FuelcardListComponent implements OnInit {
  ascDescBoolean: boolean;
  fuelCards: FuelCard[];

  pageAmounts = [5, 10, 25];
  page = 1;
  selectedAmount = 5;

  constructor(private router: Router, private fuelCardService: FuelCardService) {
  }

  ngOnInit(): void {
    this.fuelCardService.getAllFuelCards().subscribe(data => {
      this.fuelCards = data;
      console.log(data);
    });
  }

  navigateToNewFuelCardComponent(): void {
    this.router.navigate(['/fuelcards/new']);
  }

  navigateToFuelCardDetailsComponent(index: number): void {
    this.router.navigate(['/fuelcards', index]);
  }

  switchPage(event): void {
    this.page = event;
  }

  sortByDriver(): void {
    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // alphabetical ascending
      this.fuelCards.sort((t1, t2) => {
        if (!t1.driver || !t2.driver) {
          return -1;
        }
        const name1 = this.getFullName(t1.driver.person).toLowerCase();
        const name2 = this.getFullName(t2.driver.person).toLowerCase();
        if (name2 > name1) {
          return 1;
        }
        if (name2 < name1) {
          return -1;
        }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // alphabetical descending
      this.fuelCards.sort((t1, t2) => {
        if (!t1.driver || !t2.driver) {
          return -1;
        }
        const name1 = this.getFullName(t1.driver.person).toLowerCase();
        const name2 = this.getFullName(t2.driver.person).toLowerCase();
        if (name1 > name2) {
          return 1;
        }
        if (name1 < name2) {
          return -1;
        }
        return 0;
      });
    }
  }

  sortByDate(date): void {
    if (this.ascDescBoolean) {
      this.ascDescBoolean = false;

      // ascending
      this.fuelCards.sort((t1, t2) => {
        const date1 = t1[date];
        const date2 = t2[date];
        if (date2 > date1) {
          return 1;
        }
        if (date2 < date1) {
          return -1;
        }
        return 0;
      });
    } else {
      this.ascDescBoolean = true;

      // descending
      this.fuelCards.sort((t1, t2) => {
        const date1 = t1[date];
        const date2 = t2[date];
        if (date1 > date2) {
          return 1;
        }
        if (date1 < date2) {
          return -1;
        }
        return 0;
      });
    }

  }

  getFullName(person: Person): string {
    return person.firstname + '' + person.lastname;
  }
}
