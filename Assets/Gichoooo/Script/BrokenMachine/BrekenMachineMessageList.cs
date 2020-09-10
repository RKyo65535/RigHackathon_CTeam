using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrekenMachineMessageList : MonoBehaviour
{
    [SerializeField] int machineNum;
    string[] message = new string[20];

    private void Awake()
    {
        message[0] = "これは0番目のメッセージです";
        message[1] = "これは1番目のメッセージです";
        message[2] = "これは2番目のメッセージです";
        message[3] = "これは3番目のメッセージです";
        message[4] = "これは4番目のメッセージです";
        message[5] = "これは5番目のメッセージです";
        message[6] = "これは6番目のメッセージです";
        message[7] = "これは7番目のメッセージです";
        message[8] = "これは8番目のメッセージです";
        message[9] = "これは9番目のメッセージです";
        message[10] = "これは10番目のメッセージです";
        message[11] = "これは11番目のメッセージです";
        message[12] = "これは12番目のメッセージです";
        message[13] = "これは13番目のメッセージです";
        message[14] = "これは14番目のメッセージです";
        message[15] = "これは15番目のメッセージです";
        message[16] = "これは16番目のメッセージです";
        message[17] = "これは17番目のメッセージです";
        message[18] = "これは18番目のメッセージです";
        message[19] = "これは19番目のメッセージです";
    }

    public string GetMessage()
    {
        Debug.Log(machineNum);
        Debug.Log(message[machineNum]);

        return message[machineNum];
    }


}
