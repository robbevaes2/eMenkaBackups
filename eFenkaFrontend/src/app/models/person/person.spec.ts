import { Person } from './person';

describe('Person', () => {
  it('should create an instance', () => {
    expect(new Person(null, null, null, null, null, null, null, null, null, null, null)).toBeTruthy();
  });
});
