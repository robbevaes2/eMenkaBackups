import { Brand } from './brand';

describe('Brand', () => {
  it('should create an instance', () => {
    expect(new Brand(null, null)).toBeTruthy();
  });
});
