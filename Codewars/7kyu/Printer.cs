using System;

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
}