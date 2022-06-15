namespace Algo.BinarySearch
{
    public class SearchMatrix
    {
        public static bool Search(int[][] matrix, int target) {
            int lPtrMatr = 0, rPtrMatr = matrix.Length-1, midPtrMatr;
            while(lPtrMatr<=rPtrMatr){
                midPtrMatr = (rPtrMatr + lPtrMatr)/2;
                if(target == matrix[midPtrMatr][0]){
                    return true;
                }
                else if (matrix[midPtrMatr][0]<target){
                    lPtrMatr = midPtrMatr+1; 
                }
                else{
                    rPtrMatr = midPtrMatr-1;
                }
            }
            
            if(lPtrMatr<=0)
                return false;
            lPtrMatr--;

            Console.WriteLine(lPtrMatr);

            int lPtr = 0, rPtr = matrix[lPtrMatr].Length-1, midPtr;
            while(lPtr<=rPtr){
                midPtr = (rPtr + lPtr)/2;
                //Console.WriteLine(midPtr);
                if(target == matrix[lPtrMatr][midPtr]){
                    return true;
                }
                else if (matrix[lPtrMatr][midPtr] < target){
                    lPtr = midPtr + 1;
                }else{
                    rPtr = midPtr - 1;
                }
            } 

            return false;
        }
    }
}