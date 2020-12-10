import { Company } from './company';

describe('Company', () => {
  it('should create an instance', () => {
    expect(new Company(null, null, null, null, null, null, null, null, null)).toBeTruthy();
  });
});
