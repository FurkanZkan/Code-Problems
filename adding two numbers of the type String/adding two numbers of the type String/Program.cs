using System.Text;


var valOne = "800000000000000000000000000000000000000000000000000000000";
var valTwo = "400000000000000000000000000000000000000000000000000000000";

var result = topla(valOne, valTwo);
Console.WriteLine(result);




string topla(string valOne, string valTwo)
{


    if (valOne.Length < valTwo.Length)
        valTwo = valTwo.PadLeft(valOne.Length, '0');
    else
        valOne = valOne.PadLeft(valTwo.Length, '0');


    var sb = new StringBuilder();

    int leapVal = 0;

    for (int i = valOne.Length - 1; i >= 0; i--)
    {
        var firstVal = int.Parse(valOne[i].ToString());
        var lastVal = int.Parse(valTwo[i].ToString());

        var total = firstVal + lastVal + leapVal;

        leapVal = total > 9 ? 1 : 0;
        total %= 10;

        sb.Insert(0, total);

    }
    if (leapVal > 0)
        sb.Insert(0, 1);

    return sb.ToString();
}
