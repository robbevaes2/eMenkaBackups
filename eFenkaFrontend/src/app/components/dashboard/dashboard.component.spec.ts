// import { ApiService } from 'src/app/services/api.service';
// import { APP_BASE_HREF } from '@angular/common';
// import { HttpClientModule } from '@angular/common/http';
// import { ComponentFixture, TestBed } from '@angular/core/testing';
// import { RouterModule } from '@angular/router';

// import { DashboardComponent } from './dashboard.component';

// describe('DashboardComponent', () => {
//   let component: DashboardComponent;
//   let fixture: ComponentFixture<DashboardComponent>;
//   let service: ApiService;

//   beforeEach(async () => {
//     await TestBed.configureTestingModule({
//       declarations: [ DashboardComponent ],
//       imports: [
//         RouterModule.forRoot([]),
//         HttpClientModule
//       ],
//       providers: [{provide: APP_BASE_HREF, useValue : '/dashboard' }, ApiService]
//     })
//     .compileComponents();
//   });

//   beforeEach(() => {
//     fixture = TestBed.createComponent(DashboardComponent);
//     component = fixture.componentInstance;
//     fixture.detectChanges();
//     service = TestBed.get(ApiService);
//   });

//   it('should create', () => {
//     expect(component).toBeTruthy();
//   });

//   describe('#getRandomColor', () => {
//     it('should return a color', () => {
//       const color = component.getRandomColor();
//       expect(/^#[0-9A-F]{6}$/i.test(color)).toBeTrue();
//     });

//     it('should return a random color', () => {
//       const color1 = component.getRandomColor();
//       const color2 = component.getRandomColor();

//       expect(color1 !== color2).toBeTrue();
//     });
//   });
// });
