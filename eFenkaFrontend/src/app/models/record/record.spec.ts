import { Record } from './record';

describe('Record', () => {
  it('should create an instance', () => {
    expect(new Record(null, null, null, null, null, null, null, null)).toBeTruthy();
  });
});
