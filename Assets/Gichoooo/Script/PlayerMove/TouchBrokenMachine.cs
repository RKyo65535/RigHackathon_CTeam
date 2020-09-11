using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TouchBrokenMachine : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Text text;
    bool[] everGot = new bool[20];

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BrokenMachine")
        {
            if (!everGot[collision.GetComponent<BrekenMachineMessageList>().machineNum])
            {
                everGot[collision.GetComponent<BrekenMachineMessageList>().machineNum] = true;
                NumOfMachine.CountUp();
            }
            canvas.SetActive(true);
            text.text = collision.GetComponent<BrekenMachineMessageList>().GetMessage();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "BrokenMachine")
        {
            collision.GetComponent<BrekenMachineMessageList>().Close();
            canvas.SetActive(false);
        }
    }

}
