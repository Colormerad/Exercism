using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int colorVal = 0;
        string[] colors = Colors();
        for (int i = 0; i < colors.Length; i++)
        {
            if (colors[i] == color)
            {
                colorVal = i;
                break;
            }
        }
        return colorVal;
    }

    public static string[] Colors()
    {
        string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return colors;
    }
}