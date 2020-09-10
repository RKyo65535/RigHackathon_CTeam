using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TouchBrokenMachine : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Text text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BrokenMachine")
        {
            canvas.SetActive(true);
            text.text = collision.GetComponent<BrekenMachineMessageList>().GetMessage();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "BrokenMachine")
        {
            canvas.SetActive(false);
        }
    }

}
