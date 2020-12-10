import { FormControl } from '@angular/forms';
import { birthDateValidator } from "./birthdate.validator";

describe('#birthDateValidator', () => {
  const control = new FormControl('input')

  it('should return true if brithdate is after now date', () => {
    const dateBeforeNow = new Date();
    dateBeforeNow.setDate(dateBeforeNow.getDate() + 1)

    control.setValue(dateBeforeNow);
    expect(birthDateValidator(control)).toEqual({ BirthDateAfterNow: true })
  });

  it('should return null if brithdate is before now date', () => {
    const dateBeforeNow = new Date();
    dateBeforeNow.setDate(dateBeforeNow.getDate() - 1)

    control.setValue(dateBeforeNow);
    expect(birthDateValidator(control)).toEqual(null)
  });
});
