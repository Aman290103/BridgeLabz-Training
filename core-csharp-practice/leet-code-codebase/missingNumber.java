class Solution {
    public int missingNumber(int[] nums) {
        int N = nums.length;
        int sum = N*(N+1)/2;
        
        int sum2=0;

        for(int i=0;i<nums.length;i++){
            sum2+=nums[i];
        }

        return sum-sum2;
    }
}