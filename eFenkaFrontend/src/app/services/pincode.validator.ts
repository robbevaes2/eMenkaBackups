import { FormControl } from '@angular/forms';

export function pincodeValidator(control: FormControl) {
  return control.value.toString().length !== 4 ? { validPincode: true } : null;
}
