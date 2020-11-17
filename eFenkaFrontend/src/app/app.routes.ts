import { Routes } from '@angular/router';
import { NewVehicleItemComponent } from './components/new-vehicle-item/new-vehicle-item.component';
import { VehicleListComponent } from './components/vehicle-list/vehicle-list.component';

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
  },/*
  {
    path: 'vehicles/:index',
    component: VehicleListComponent
  },*/
  {
    path: 'vehicles/new',
    component: NewVehicleItemComponent
  }
];
