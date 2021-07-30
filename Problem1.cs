namespace Weekly 
{
    public class Problem1
    {
        public static void main()
        {
       int[] nums = new int[] {90,21,15,12,70,66,89,7};
        int val = 97;
        for (int i = 0; i < nums.Length; i++)
        {
            int sum = 0;
            for(int j =i ; j < nums.Length;j++)
            {
                sum= sum + nums[j];
                if(sum ==x )
                {   
                    Console.WriteLine("Sum found between index " + i + " to " + j);
                    Console.Write("The following numbers are ");
                    for (int k=i;k<= j ; k++)
                    Console.WriteLine(nums[k]);
                }
                return;
            }
        }
            return;
        }
    }
}