using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scientistScript : MonoBehaviour
{

    public enum Way
    {
        LEFT,RIGHT
    }

    Animator anim;
    Transform TF;


    // Start is called before the first frame update
    void Awake()
    {
        TF = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    public void WolkAnim(Way way)
    {
        if(way == Way.LEFT)
        {
            TF.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            TF.rotation = Quaternion.Euler(0, 180, 0);

        }

        anim.SetBool("isWalk", true);
        anim.SetBool("isNormal", false);
        anim.SetBool("isJet", false);
        anim.SetBool("isChain", false);
    }

    public void NormalAnim()
    {
        TF.rotation = Quaternion.Euler(0,-90, 0);
        anim.SetBool("isWalk", false);
        anim.SetBool("isNormal", true);
        anim.SetBool("isJet", false);
        anim.SetBool("isChain", false);
    }
    public void JetAnim()
    {
        TF.rotation = Quaternion.Euler(0, 90, 0);
        anim.SetBool("isWalk", false);
        anim.SetBool("isNormal", false);
        anim.SetBool("isJet", true);
        anim.SetBool("isChain", false);
    }
    public void ChainAnim()
    {
        TF.rotation = Quaternion.Euler(0, 90, 0);
        anim.SetBool("isWalk", false);
        anim.SetBool("isNormal", false);
        anim.SetBool("isJet", false);
        anim.SetBool("isChain",true );
    }

}
