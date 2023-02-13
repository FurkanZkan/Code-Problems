//Given an integer x, return true if x is a palindrome integer.

//An integer is a palindrome when it reads the same backward as forward.

//Input: x = 121
//Output: true
//Explanation: 121 reads as 121 from left to right and from right to left.


//Input: x = 10
//Output: false
//Explanation: Reads 01 from right to left.Therefore it is not a palindrome.



bool isPalindrome(int num)
{
    int tempNum = num;
    int reverseOfNum = 0;

    if (tempNum < 0)
    {
        return false;
    }
    while(tempNum > 0)
    {
        reverseOfNum = reverseOfNum * 10 + tempNum % 10;
        tempNum /= 10;
    }
    return num == reverseOfNum;
}

Console.WriteLine(isPalindrome(10));

