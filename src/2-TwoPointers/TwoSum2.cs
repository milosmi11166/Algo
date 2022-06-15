namespace Algo.TwoPointers
{
    public class TwoSum2
    {
        // -5,0,3,4 -2
        public static int[] TwoSum(int[] numbers, int target) {
            int lPtr = 0;
            int rPtr = numbers.Length - 1;
            while(lPtr < rPtr){
                if(numbers[lPtr] + numbers[rPtr] == target){
                    return new int[2]{lPtr+1, rPtr+1};
                }

                if(numbers[lPtr] + numbers[rPtr] > target){
                    rPtr--;
                }else{
                    lPtr++;
                }
            }

            return new int[0];
        }
    }
}