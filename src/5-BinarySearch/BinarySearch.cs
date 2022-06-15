namespace Algo.BinarySearch
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target) {
            int lPtr = 0, rPtr = nums.Length -1, midPtr;
            while ((rPtr - lPtr) >= 2)
            {
                midPtr = (rPtr + lPtr) / 2;
                if(target > nums[midPtr]){
                    lPtr = midPtr;
                }
                else if(target < nums[midPtr]){
                    rPtr = midPtr + 1;
                }
                else{
                    return midPtr;
                }
            }
            return -1;
        }
    }
}