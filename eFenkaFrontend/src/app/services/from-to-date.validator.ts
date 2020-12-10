import { FormGroup } from '@angular/forms';

export function fromToDate(control: FormGroup) {
  return control.get('endDate').value < control.get('startDate').value ? { EndDateBeforeSelectedStartDate: true } : null;
}
