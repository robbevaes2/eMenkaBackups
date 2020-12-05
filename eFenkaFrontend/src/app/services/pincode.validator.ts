import { FormGroup } from '@angular/forms';

export function pincodeValidator(control: FormGroup) {
  return control.value?.toString().length !== 4 ? { validPincode: true } : null;
}
