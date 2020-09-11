using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDelete : MonoBehaviour
{
    float passedTime;
    [SerializeField] float deathTime;
    // Start is called before the first frame update
    void Awake()
    {
        passedTime = Time.deltaTime;
        passedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        passedTime += Time.deltaTime;
        if(passedTime > deathTime)
        {
            Destroy(gameObject);
        }
    }
}
