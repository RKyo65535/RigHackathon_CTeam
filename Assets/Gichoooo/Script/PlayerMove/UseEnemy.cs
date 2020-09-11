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

    int count;
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

    private void Update()
    {

        if (count == 0)
        {
            pushButton.pushC = Input.GetKeyDown(KeyCode.C);
            pushButton.pushZ = Input.GetKeyDown(KeyCode.Z);
            pushButton.pushX = Input.GetKeyDown(KeyCode.X);
            if(pushButton.pushC || pushButton.pushZ || pushButton.pushX)
            {
                count = 20;

            }
        }  
    }


    private void FixedUpdate()
    {
        if(count == 10)
        {
            pushButton.pushC = false;
            pushButton.pushZ = false;
            pushButton.pushX = false;
        }
        if(count > 0)
        {
            count--;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(collision);
        if(collision.tag == "Magma" && pushButton.pushZ && jetPack.canControl)
        {
            jetPack.electricPower = jetPack.maxElectricPower-1;
            collision.gameObject.SetActive(false);
        }
        else if (collision.tag == "Obstacle" && pushButton.pushC && jetPack.canControl)
        {
            if (collision.transform.position.x > transform.position.x)
            {
                playerRigidBody.velocity = new Vector2(-10, 60);
            }
            else
            {
                playerRigidBody.velocity = new Vector2(10, 60);
            }
            collision.gameObject.SetActive(false);
        }
    }






}
