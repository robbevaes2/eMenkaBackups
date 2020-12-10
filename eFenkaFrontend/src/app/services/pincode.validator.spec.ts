import { FormControl } from "@angular/forms";
import { pincodeValidator } from './pincode.validator';

describe('#pincodeValidator', () => {
  const control = new FormControl('input')

  it('should return true if pincode is too long', () => {
    const tooLongPinCode = '12345';

    control.setValue(tooLongPinCode);
    expect(pincodeValidator(control)).toEqual({ validPincode: true })
  });

  it('should return true if pincode is too short', () => {
    const tooShortPinCode = '123';

    control.setValue(tooShortPinCode);
    expect(pincodeValidator(control)).toEqual({ validPincode: true })
  });

  it('should return null if pincode is valid', () => {
    const validPinCode = '1234';

    control.setValue(validPinCode);
    expect(pincodeValidator(control)).toEqual(null)
  });
});
