using Logging;
using UnityEngine;

public class Entry : MonoBehaviour
{
    private void Start()
    {
        var logger = new FileLogger("log.txt");
        try
        {
            logger.Log("Hello World");
        }
        catch (System.Exception e)
        {
            Debug.LogException(e);
        }
        finally
        {
            logger.Dispose();
        }
        
    }
}

