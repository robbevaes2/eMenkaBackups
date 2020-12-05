import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SupplierType } from 'src/app/enums/supplier-type/supplier-type.enum';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-new-supplier-item',
  templateUrl: './new-supplier-item.component.html',
  styleUrls: ['./new-supplier-item.component.css']
})
export class NewSupplierItemComponent implements OnInit {
  form: FormGroup;
  types = Object.values(SupplierType).filter(value => typeof value === 'string');

  constructor(private router: Router, private apiService: ApiService) { }

  ngOnInit(): void {
    this.form = new FormGroup({
      name: new FormControl(null, [Validators.required]),
      active: new FormControl(false),
      internal: new FormControl(false),
      supplierTypes: new FormArray([])
    });

    this.addCheckboxesToSupplierTypes();
  }

  get typesFormArray(): FormArray {
    return this.form.controls.supplierTypes as FormArray;
  }

  addCheckboxesToSupplierTypes(): void {
    this.types.forEach(() => {
      this.typesFormArray.push(new FormControl(false));
    });
  }

  navigateToListSupplierComponent(): void {
    this.router.navigate(['/suppliers']);
  }

  mapToSupplierModel(values: any): any {
    return {
      name:  values.name,
      active:  values.active,
      internal:  values.internal,
      types:  this.mapTypes(values.supplierTypes),
    };
  }

  mapTypes(types: boolean[]): number[] {
    const numberOfTypes = [];

    for (let i = 0; i < types.length; i++) {
      if (types[i]) {
        numberOfTypes.push(i);
      }
    }
    return numberOfTypes;
  }

  saveNewSupplier(form: FormGroup): void {
    if (confirm('Bent u zeker dat u deze leverancier wilt opslaan?')) {
      const supplierModel = this.mapToSupplierModel(form.value);
      this.apiService.addSupplier(supplierModel).subscribe(() => this.navigateToListSupplierComponent());
    }
  }
}
