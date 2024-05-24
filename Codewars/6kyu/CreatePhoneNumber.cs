public static string CreatePhoneNumber(int[] numbers)
{
    string _first = "";
    string _second = "";
    string _third = "";

    for (int i = 0; i < numbers.Length; i++)
    {
        if (i <= 2)
            _first += numbers[i].ToString();
        else if (i <= 5)
            _second += numbers[i].ToString();
        else
            _third += numbers[i].ToString();
    }

    return $"({_first}) {_second}-{_third}";
}


public static string AltCreatePhoneNumber(int[] numbers)
{
    string phoneNumber = string.Concat(numbers);
    
    return $"({phoneNumber.Substring(0,3)}) {phoneNumber.Substring(3, 3)}-{phoneNumber.Substring(6,4)}";
}