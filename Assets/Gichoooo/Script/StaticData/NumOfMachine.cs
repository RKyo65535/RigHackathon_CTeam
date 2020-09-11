using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumOfMachine : MonoBehaviour
{
    static int touchNum;


    public static void CountUp()
    {
        touchNum++;
        Debug.Log("増えました　今の数は" + touchNum);
    }

    public static int GetNum()
    {
        return touchNum;
    }

    public static void Reset()
    {
        touchNum = 0;
    }

}
