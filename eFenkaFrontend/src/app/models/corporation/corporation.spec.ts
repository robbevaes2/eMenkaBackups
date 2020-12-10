import { Corporation } from './corporation';

describe('Corporation', () => {
  it('should create an instance', () => {
    expect(new Corporation(null, null, null, null, null, null)).toBeTruthy();
  });
});
