using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseEnemy : MonoBehaviour
{
    [SerializeField] GameObject Player;
    PlayerJetPack jetPack;
    Rigidbody2D playerRigidBody;


    Rigidbody2D RB;
    PushButton pushButton;

    class PushButton
    {
        public bool pushZ;
        public bool pushX;
        public bool pushC;
    }

    private void Awake()
    {
        pushButton = new PushButton();
        jetPack = Player.GetComponent<PlayerJetPack>();
        playerRigidBody = Player.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Magma" && Input.GetKeyDown(KeyCode.Z) && jetPack.canControl)
        {
            jetPack.electricPower = 300;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Obstacle" && Input.GetKeyDown(KeyCode.C) && jetPack.canControl)
        {
            if (collision.transform.position.x > transform.position.x)
            {
                playerRigidBody.velocity = new Vector2(-10, 60);
            }
            else
            {
                playerRigidBody.velocity = new Vector2(10, 60);
            }
            Destroy(collision.gameObject);
        }
    }






}
