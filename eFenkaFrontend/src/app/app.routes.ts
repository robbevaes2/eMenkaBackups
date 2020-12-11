import { RecordDetailsComponent } from './components/record-details/record-details.component';
import { NewRecordItemComponent } from './components/new-record-item/new-record-item.component';
import { RecordListComponent } from './components/record-list/record-list.component';
import { Routes } from '@angular/router';
import { NewVehicleItemComponent } from './components/new-vehicle-item/new-vehicle-item.component';
import { VehicleListComponent } from './components/vehicle-list/vehicle-list.component';
import { VehicleDetailsComponent } from './components/vehicle-details/vehicle-details.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { DriverListComponent } from './components/driver-list/driver-list.component';
import { DriverDetailsComponent } from './components/driver-details/driver-details.component';
import { NewDriverItemComponent } from './components/new-driver-item/new-driver-item.component';
import {FuelcardDetailsComponent} from './components/fuelcard-details/fuelcard-details.component';
import {FuelcardListComponent} from './components/fuelcard-list/fuelcard-list.component';
import { DashboardModelChartComponent } from './components/dashboard-model-chart/dashboard-model-chart.component';
import {NewFuelcardItemComponent} from './components/new-fuelcard-item/new-fuelcard-item.component';
import { SupplierListComponent } from './components/supplier-list/supplier-list.component';
import { SupplierDetailsComponent } from './components/supplier-details/supplier-details.component';
import { NewSupplierItemComponent } from './components/new-supplier-item/new-supplier-item.component';

export const appRoutes: Routes = [
  /*{
    path: 'files',
    component: FileListComponent // Change component names
  },
  {
    path: 'files/:index',
    component: FileDetailsComponent
  },
  {
    path: 'files/new',
    component: FileCreateComponent
  },*/
  {
    path: 'suppliers',
    component: SupplierListComponent
  },
  {
    path: 'suppliers/new',
    component: NewSupplierItemComponent
  },
  {
    path: 'suppliers/:index',
    component: SupplierDetailsComponent
  },
  {
    path: 'vehicles',
    component: VehicleListComponent
  },
  {
    path: 'vehicles/new',
    component: NewVehicleItemComponent
  },
  {
    path: 'vehicles/:index',
    component: VehicleDetailsComponent
  },
  {
    path: 'records',
    component: RecordListComponent
  },
  {
    path: 'records/new',
    component: NewRecordItemComponent
  },
  {
    path: 'records/:index',
    component: RecordDetailsComponent
  },
  {
    path: 'fuelcards',
    component: FuelcardListComponent
  },
  {
    path: 'fuelcards/new',
    component: NewFuelcardItemComponent
  },
  {
    path: 'fuelcards/:index',
    component: FuelcardDetailsComponent
  },
  {
    path: 'drivers',
    component: DriverListComponent
  },
  {
    path: 'drivers/new',
    component: NewDriverItemComponent
  },
  {
    path: 'drivers/:index',
    component: DriverDetailsComponent
  },
  {
    path: 'models/:index',
    component: DashboardModelChartComponent
  },
  {
    path: 'dashboard',
    component: DashboardComponent
  },
  {
    path: '',
    redirectTo: 'dashboard', pathMatch: 'full'
  },
];
