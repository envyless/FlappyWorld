using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using Debug = UnityEngine.Debug;

public static partial class CommonUtils
{
    public static object ByteToObject(this byte[] buffer)
    {
        try
        {
            using (MemoryStream stream = new MemoryStream(buffer))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                stream.Position = 0;
                return binaryFormatter.Deserialize(stream);
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }
        return null;
    }

    public static byte[] ObjectToByte(this object obj)
    {
        try
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, obj);
                return stream.ToArray();
            }
        }
        catch (Exception exception)
        {
            Debug.LogError(exception.ToString());
        }
        return null;
    }
}
