using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak()
    {
        string result = string.Empty;


        result += "One for you, one for me.";

        return result;

    }

    public static string Speak(string name)
    {
        string result = string.Empty;

        if (name == string.Empty)
        {
            result += "One for you";
        }
        else
        {
            result += "One for " + name;
        }

        result += ", one for me.";

        return result;
        
    }
}
