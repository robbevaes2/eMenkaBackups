import { CostAllocation } from './cost-allocation';

describe('CostAllocation', () => {
  it('should create an instance', () => {
    expect(new CostAllocation(null, null, null, null, null)).toBeTruthy();
  });
});
