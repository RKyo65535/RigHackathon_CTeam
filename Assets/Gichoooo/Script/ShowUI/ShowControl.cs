using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControl : MonoBehaviour
{
    public void ChangeActive()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
