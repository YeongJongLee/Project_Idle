using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.TextCore.Text;
using TMPro;
using UnityEditor;
using UnityEngine.UI;

public class Util
{
    static readonly string[] Units = new string[] { "", "A", "B", "C", "D", "E", "F", "G",
        "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y",
        "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN",
        "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC",
        "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR",
        "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CA", "CB", "CC", "CD", "CE", "CF", "CG",
        "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX" };

    public static string NumberConversation(double number)
    {
        string numString = string.Empty;
        string unitString = string.Empty;

        if (number < 1000)
        {
            numString = number.ToString();
            unitString = Units[0];

            return string.Format("{0}{1}", numString, unitString);
        }

        string[] splitNum = number.ToString("E").Split('+');

        int.TryParse(splitNum[1], out int result);

        int quotient = result / 3;
        int remain = result % 3;

        if (result < 3)
        {
            numString = System.Math.Truncate(number).ToString();
        }
        else
        {
            var temp = double.Parse(splitNum[0].Replace("E", "")) * System.Math.Pow(10, remain);

            numString = temp.ToString("F").Replace(".00", "");
        }

        unitString = Units[quotient];

        return string.Format("{0}{1}", numString, unitString);
    }

}
