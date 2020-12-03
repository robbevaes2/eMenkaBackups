import { RecordDetailsComponent } from './components/record-details/record-details.component';
import { NewRecordItemComponent } from './components/new-record-item/new-record-item.component';
import { RecordListComponent } from './components/record-list/record-list.component';
import { Routes } from '@angular/router';
import { NewVehicleItemComponent } from './components/new-vehicle-item/new-vehicle-item.component';
import { VehicleListComponent } from './components/vehicle-list/vehicle-list.component';
import { VehicleDetailsComponent } from './components/vehicle-details/vehicle-details.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';

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
  },
  {
    path: 'drivers',
    component: DriverListComponent
  },
  {
    path: 'drivers/:index',
    component: DriverDetailsComponent
  },
  {
    path: 'drivers/new',
    component: DriverCreateComponent
  },
  {
    path: 'suppliers',
    component: SupplierListComponent
  },
  {
    path: 'suppliers/:index',
    component: SupplierDetailsComponent
  },
  {
    path: 'suppliers/new',
    component: SupplierCreateComponent
  },*/
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
    path: 'dashboard',
    component: DashboardComponent
  },
  {
    path: '',
    redirectTo: 'dashboard', pathMatch: 'full'
  },
];
