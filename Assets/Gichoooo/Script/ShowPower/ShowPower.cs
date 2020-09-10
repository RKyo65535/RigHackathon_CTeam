using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowPower : MonoBehaviour
{
    [SerializeField] PlayerJetPack jetPack;
    Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Power : "+jetPack.electricPower;
    }
}
