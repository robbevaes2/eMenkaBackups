import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiService } from 'src/app/services/api.service';
import { Supplier } from '../../models/supplier/supplier';
import { SupplierType } from '../../enums/supplier-type/supplier-type.enum';

@Component({
  selector: 'app-supplier-details',
  templateUrl: './supplier-details.component.html',
  styleUrls: ['./supplier-details.component.css']
})
export class SupplierDetailsComponent implements OnInit {
  form: FormGroup;
  selectedSupplier: Supplier;
  isEditable: boolean;
  types = Object.values(SupplierType).filter(value => typeof value === 'string');

  constructor(private route: ActivatedRoute, private router: Router, private apiService: ApiService, private datePipe: DatePipe) { }

  ngOnInit(): void {
    const supplierId = this.route.snapshot.params.index;
    this.apiService.getSupplierById(supplierId).subscribe(data => {
      this.selectedSupplier = data;

      this.form = new FormGroup({
        name: new FormControl(null, [Validators.required]),
        active: new FormControl(false),
        internal: new FormControl(false),
        supplierTypes: new FormArray([])
      });

      this.addCheckboxesToSupplierTypes();

      this.fillForm();
      this.disableForm();
    });
  }

  get typesFormArray(): FormArray {
    return this.form.controls.supplierTypes as FormArray;
  }

  addCheckboxesToSupplierTypes(): void {
    this.types.forEach(() => {
      this.typesFormArray.push(new FormControl(false));
    });
  }

  fillForm(): void {
    this.form.controls.name.setValue(this.selectedSupplier.name);
    this.form.controls.active.setValue(this.selectedSupplier.active);
    this.form.controls.internal.setValue(this.selectedSupplier.internal);
    this.fillTypesCheckboxes();
  }

  fillTypesCheckboxes(): void {
    if (this.selectedSupplier.types !== null) {
      for (let i = 0; i < this.types.length; i++) {
        let isChecked = false;

        if (this.selectedSupplier.types.includes(i)) {
          isChecked = true;
        }

        this.typesFormArray.at(i).setValue(isChecked);
      }
    }
  }

  disableForm(): void {
    this.form.controls.name.disable();
    this.form.controls.active.disable();
    this.form.controls.internal.disable();
    this.form.controls.supplierTypes.disable();
    this.isEditable = false;
  }

  enableForm(): void {
    this.form.controls.name.enable();
    this.form.controls.active.enable();
    this.form.controls.internal.enable();
    this.form.controls.supplierTypes.enable();
    this.isEditable = true;
  }

  navigateToListSupplierComponent(): void {
    this.router.navigate(['/suppliers']);
  }

  mapToSupplierModel(values: any): any {
    return {
      id: this.selectedSupplier.id,
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

  saveEditSupplier(form: FormGroup): void {
    if (this.isEditable) {
      if (confirm('Bent u zeker dat u deze leverancier wilt opslaan?')) {
        this.apiService.updateSupplier(this.selectedSupplier.id, this.mapToSupplierModel(form.value)).subscribe(() => {
            this.apiService.getSupplierById(this.selectedSupplier.id).subscribe(data => {
              this.selectedSupplier = data;
              this.fillForm();
              this.disableForm();
            });
        });
      }
    } else {
      this.enableForm();
    }
  }

  deleteSupplier(): void {
    if (confirm('Bent u zeker dat u deze leverancier wilt verwijderen?')) {
      this.apiService.deleteSupplier(this.selectedSupplier.id).subscribe(() => this.navigateToListSupplierComponent());
    }
  }

  cancel(): void {
    this.fillForm();
    this.disableForm();
  }
}
