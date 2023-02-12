//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.


//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].



int[] nums = new int[]  { 2, 7, 11, 15};

int targetNum = 9;



#region solutionOne

for (int i = 0; i < nums.Length; i++)
{
    for (int j = i; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == targetNum)
        {

            Console.WriteLine("Solution one code output => [{0},{1}] Time Complexity: O(n²) Space Complexity: O(1) ", i, j);
        }
        
    }
}
#endregion

#region solutionTwo

int[] TwoSum(int[] nums, int target)
{
    var map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (map.ContainsKey(complement))
        {
            return new int[] { map[complement], i };
        }
        map[nums[i]] = i;
       
    }
    throw new Exception("No two sum solution");
}
TwoSum(nums, targetNum);



int[] arr = TwoSum(nums, targetNum);

Console.WriteLine("Solution two code output => [{0},{1}] Time Complexity: O(n)  Space Complexity: O(n)", arr[0] , arr[1]);

#endregion






