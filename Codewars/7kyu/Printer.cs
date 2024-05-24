using System;
using System.Collections.Generic;
using System.Linq;

public class Printer 
{
    public static string PrinterError(String s) 
    {
        int errorCount = 0;
        var validColors = "abcdefghijklm".ToCharArray();

        foreach (char c in s)
        {
            bool isValid = false;
          
            foreach (char alphabet in validColors)
            {
                if (c == alphabet)
                {
                    isValid = true;
                    break;
                }
            }
          
            if (!isValid)
                errorCount++;
        }

        return $"{errorCount}/{s.Length}";
    }

    public static string LinqPrinterError(String s) 
    {
        var colors = new HashSet<char>("abcdefghijklm");
        int errorCount = s.Count(c => !colors.Contains(c));
        return $"{errorCount}/{s.Length}";
    }
}