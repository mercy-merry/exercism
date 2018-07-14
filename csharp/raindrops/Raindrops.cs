﻿using System.Globalization;
using System.Text;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var drops = new StringBuilder(capacity: 15);

        if (number % 3 == 0)
        {
            drops.Append("Pling");
        }

        if (number % 5 == 0)
        {
            drops.Append("Plang");
        }

        if (number % 7 == 0)
        {
            drops.Append("Plong");
        }

        return drops.Length > 0 ? drops.ToString() : number.ToString(CultureInfo.InvariantCulture);
    }
}