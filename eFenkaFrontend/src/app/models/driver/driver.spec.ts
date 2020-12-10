import { Driver } from './driver';

describe('Driver', () => {
  it('should create an instance', () => {
    expect(new Driver(null, null, null, null, null)).toBeTruthy();
  });
});
