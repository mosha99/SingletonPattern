global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
using System.Numerics;
namespace SingletonPattern;

public class Calculator
{
    private static Calculator _Calculator { get; set; }
    private List<string> _Log { get; set; }
    private Calculator()
    {
        _Log = new List<string>();
        Sum(1,2,3);
    }
    public static Calculator GetCalculator()
    {
        if (_Calculator is null) _Calculator = new Calculator();
        return _Calculator;
        
    }
    public string GetLog()
    {
        StringBuilder sb = new StringBuilder();
        _Log.ForEach(l=> sb.AppendLine("- " + l));
        sb.AppendLine("******************************************************************");
        return sb.ToString();
    }



    public int Sum(params int[] Num)
    {
        int sum = 0;
        StringBuilder Log = new StringBuilder($"Sum Numbers ");

        for (int i = 0; i < Num.Length; i++)
        {
            if(i == 0) Log.Append("{");
            sum += Num[i];
            Log.Append($" {Num[i]} ");
            if(i != Num.Length - 1) Log.Append("+");
            else Log.Append("}");
        }
        _Log.Add(Log.ToString());
        return sum;
    }

    public int multiply(params int[] Num)
    {
        int sum = 1;
        StringBuilder Log = new StringBuilder($"Multiply Numbers ");

        for (int i = 0; i < Num.Length; i++)
        {
            if(i == 0) Log.Append("{");
            sum *= Num[i];
            Log.Append($" {Num[i]} ");
            if(i != Num.Length - 1) Log.Append("*");
            else Log.Append("}");
        }
        _Log.Add(Log.ToString());
        return sum;
    }

}
