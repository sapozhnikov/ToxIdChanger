using System;
using System.Text;
using System.Collections.Generic;

public static class Utils
{
    public static string BinToString(byte[] data, int startIndex, int length)
    {
        StringBuilder result = new StringBuilder();
        for (int i = startIndex; i < startIndex + length; i++)
            result.Append(data[i].ToString("X2"));
            
        return result.ToString();
    }

    public static byte[] StringToBin(string data)
    {
        List<byte> bytes = new List<byte>();

        for (int i = 0; i < data.Length; i+=2)
        {
            bytes.Add(Convert.ToByte(data.Substring(i, 2), 16));
        }

        return bytes.ToArray();
    }
}
