using UnityEngine;
using System.Collections;
using System;



public class CommonUtil
{
    /// <summary>
    /// Converts bool value true/false to int value 0/1.
    /// </summary>
    /// <returns>The int value.</returns>
    /// <param name="value">The bool value.</param>
    public static int TrueFalseBoolToZeroOne(bool value)
    {
        if (value)
        {
            return 1;
        }
        return 0;
    }

    /// <summary>
    /// Converts int value 0/1 to bool value true/false.
    /// </summary>
    /// <returns>The bool value.</returns>
    /// <param name="value">The int value.</param>
    public static bool ZeroOneToTrueFalseBool(int value)
    {
        if (value == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}