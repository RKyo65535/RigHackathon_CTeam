using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFallObject : MonoBehaviour
{
    private PlayerJetPack playerJet;
    private Rigidbody2D playerRigidBody;

    [SerializeField] float RockHitPunishmentPower;
    [SerializeField] float MagmaHitPunishmentPower;
    [SerializeField] AudioSource magmaAudio;
    [SerializeField] AudioSource rockAudio;


    // Start is called before the first frame update
    void Awake()
    {
        playerJet = GetComponent<PlayerJetPack>();
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            rockAudio.Play();
            playerRigidBody.velocity = new Vector2(0, -RockHitPunishmentPower);
            playerJet.canControl = false;
        }
        else if (collision.tag == "Magma")
        {
            float arg =Random.value*360 * Mathf.Deg2Rad;
            magmaAudio.Play();
            playerRigidBody.velocity = new Vector2(MagmaHitPunishmentPower * Mathf.Cos(arg), MagmaHitPunishmentPower * Mathf.Sin(arg));
            playerJet.canControl = false;
        }



    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.tag == "Floor")
        {
            playerRigidBody.velocity = new Vector2(0, playerRigidBody.velocity.y);//着地したら横方向の加速は０に
            playerJet.canControl = true;
        }



    }



}
