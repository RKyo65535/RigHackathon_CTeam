using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SometimesExplosion : MonoBehaviour
{
    [SerializeField]int interbal;
    [SerializeField]int randomAdditionalInterbal;
    AudioSource audioSource;
    int time;
    int nextTime;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        nextTime = DicideNextInterval();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(++time > nextTime)
        {
            audioSource.Play();
            nextTime = DicideNextInterval();
            time = 0;
        }
    }


    int DicideNextInterval()
    {
        return interbal + Random.Range(0, randomAdditionalInterbal);
    }
}
