using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Orion;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class TestWindow : MonoBehaviour
{
    
  
    byte[] ObjectToByteArray(object obj)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (MemoryStream memoryStream = new MemoryStream())
        {
            formatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }
    }
    string FormatMemoryGrid(byte[] byteArray)
    {
        int rows = 16; // Number of rows
        int cols = 16; // Number of columns

        // Create a StringBuilder to efficiently build the formatted grid
        System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

        // Header row with column addresses (0x00 - 0x0F)
        stringBuilder.Append("      ");
        for (int col = 0; col < cols; col++)
        {
            stringBuilder.AppendFormat("{0:X2}  ", col);
        }
        stringBuilder.AppendLine();

        // Rows with row address and data
        for (int row = 0; row < rows; row++)
        {
            // Row address (0x00 - 0x0F)
            stringBuilder.AppendFormat("{0:X2} | ", row * cols);

            // Data in each column
            for (int col = 0; col < cols; col++)
            {
                int index = row * cols + col;

                // Check if the index is within the array bounds
                if (index < byteArray.Length)
                {
                    // Append byte value in hexadecimal format
                    stringBuilder.AppendFormat("{0:X2}  ", byteArray[index]);
                }
                else
                {
                    // Append spaces if index is out of bounds
                    stringBuilder.Append("    ");
                }
            }
            stringBuilder.AppendLine();
        }

        return stringBuilder.ToString();
    }


}
