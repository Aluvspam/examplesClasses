using System;

public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        int rest = year % 100;
        int century = year / 100;
        if (rest >= 1)
        {
            return century + 1;
        }
        else
        {
            return century;
        }
    }
}
