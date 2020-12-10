import { FormControl, FormGroup } from '@angular/forms';
import { fromToDate } from './from-to-date.validator';

describe('#fromToDate', () => {
  const formGroup = new FormGroup({
    startDate: new FormControl(null),
    endDate: new FormControl(null)
  })

  it('should return true if startDate is after endDate', () => {
    const startDate = new Date('10-10-2010');
    const endDate = new Date('1-10-2010');

    formGroup.controls.startDate.setValue(startDate);
    formGroup.controls.endDate.setValue(endDate);
    expect(fromToDate(formGroup)).toEqual({ EndDateBeforeSelectedStartDate: true })
  });

  it('should return null if startDate is before endDate', () => {
    const startDate = new Date('10-10-2010');
    const endDate = new Date('11-10-2010');

    formGroup.controls.startDate.setValue(startDate);
    formGroup.controls.endDate.setValue(endDate);
    expect(fromToDate(formGroup)).toEqual(null)
  });
});
