import { FormControl } from '@angular/forms';

export function birthDateValidator(control: FormControl) {
  return new Date(control.value) > new Date()  ? { BirthDateAfterNow: true } : null;
}
