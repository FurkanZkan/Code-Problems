/*
 You are given a large integer represented as an integer array digits,
where each digits[i] is the ith digit of the integer. 
The digits are ordered from most significant to least significant in left-to-right order.
The large integer does not contain any leading 0's.
Increment the large integer by one and return the resulting array of digits.

Example
    Input: digits = [1,2,3]
    Output: [1,2,4]
    Explanation: The array represents the integer 123.
    Incrementing by one gives 123 + 1 = 124.
    Thus, the result should be [1,2,4].

 */
int[] digits = { 1, 2, 3 };

printTheArray(digits);
printTheArray(plusOne(digits));

int[] plusOne(int[] digits)
{

    for (int i = digits.Length - 1; i >= 0; i--)
    {
        int digit = digits[i];


        if (digit < 9)
        {
            digits[i] = digit + 1;
            return digits;
        }
        else
        {

            digits[i] = 0;
        }
    }

    int[] newDigitArray = new int[digits.Length + 1];
    newDigitArray[0] = 1;

    return newDigitArray;
}

void printTheArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write("{0} ", item);
    }
}