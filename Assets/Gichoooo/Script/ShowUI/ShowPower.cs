using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowPower : MonoBehaviour
{
    Transform TF;
    Vector3 firstPos;
    SpriteRenderer spriteRenderer;
    float spriteHeight;
    [SerializeField] PlayerJetPack jetPack;

    private void Awake()
    {
        spriteHeight = GetComponent<SpriteRenderer>().bounds.size.y;
     
        TF = GetComponent<Transform>();
        firstPos = TF.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        TF.localPosition = firstPos + new Vector3(0,spriteHeight * -((jetPack.maxElectricPower - jetPack.electricPower) /(float)jetPack.maxElectricPower),0);
    }
}
