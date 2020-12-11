import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { RouterModule } from '@angular/router';
import { appRoutes } from './app.routes';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { VehicleListComponent } from './components/vehicle-list/vehicle-list.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { NgxPaginationModule } from 'ngx-pagination';
import { NewVehicleItemComponent } from './components/new-vehicle-item/new-vehicle-item.component';
import { RecordListComponent } from './components/record-list/record-list.component';
import { VehicleDetailsComponent } from './components/vehicle-details/vehicle-details.component';
import { NewRecordItemComponent } from './components/new-record-item/new-record-item.component';
import { RecordDetailsComponent } from './components/record-details/record-details.component';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { HttpClientModule } from '@angular/common/http';
import { ApiService } from './services/api.service';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import {FuelcardDetailsComponent} from './components/fuelcard-details/fuelcard-details.component';
import {CommonModule, DatePipe} from '@angular/common';
import { DashboardModelChartComponent } from './components/dashboard-model-chart/dashboard-model-chart.component';
import { DashboardChartsComponent } from './components/dashboard-charts/dashboard-charts.component';
import { NewFuelcardItemComponent } from './components/new-fuelcard-item/new-fuelcard-item.component';
import { SupplierListComponent } from './components/supplier-list/supplier-list.component';
import { SupplierDetailsComponent } from './components/supplier-details/supplier-details.component';
import { NewSupplierItemComponent } from './components/new-supplier-item/new-supplier-item.component';
import {DriverListComponent} from './components/driver-list/driver-list.component';
import {NewDriverItemComponent} from './components/new-driver-item/new-driver-item.component';
import {DriverDetailsComponent} from './components/driver-details/driver-details.component';
import {FuelcardListComponent} from './components/fuelcard-list/fuelcard-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    VehicleListComponent,
    NewVehicleItemComponent,
    RecordListComponent,
    VehicleDetailsComponent,
    NewRecordItemComponent,
    RecordDetailsComponent,
    DashboardComponent,
    FuelcardListComponent,
    FuelcardDetailsComponent,
    DriverListComponent,
    DriverDetailsComponent,
    NewDriverItemComponent,
    DashboardModelChartComponent,
    DashboardChartsComponent,
    NewFuelcardItemComponent,
    SupplierListComponent,
    SupplierDetailsComponent,
    NewSupplierItemComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
    FontAwesomeModule,
    NgxPaginationModule,
    ReactiveFormsModule,
    MDBBootstrapModule,
    HttpClientModule,
    CommonModule
  ],
  providers: [ApiService, DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
