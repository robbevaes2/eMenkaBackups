import { FormGroup } from '@angular/forms';

export function birthDateValidator(control: FormGroup) {
  return new Date(control.value) > new Date()  ? { BirthDateAfterNow: true } : null;
}
