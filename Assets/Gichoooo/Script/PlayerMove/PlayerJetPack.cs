using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJetPack : MonoBehaviour
{
    [SerializeField] GameObject jetCage;

    public bool canControl;

    private Rigidbody2D playerRigidBody;
    private Transform playerTransForm;

    [SerializeField] float HorizonalSpeed;
    [SerializeField] float VerticalSpeed;
    [SerializeField] float VerticalMaxSpeed;
    [SerializeField] float VerticalMinimumGuaranteeSpeed;//上方向加速時の最低保証スピード
   

    [NonSerialized] public int electricPower;
    public int maxElectricPower;

    class PushButton
    {
        public bool pushSpace;
        public bool pushLeft;
        public bool pushRight;
        public bool pushUp;
        public bool pushDown;
        public bool onChain;
    }
    PushButton pushButton;


    // Start is called before the first frame update
    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        playerTransForm = GetComponent<Transform>();
        pushButton = new PushButton();
        canControl = true;

        electricPower = maxElectricPower;

    }

    // Update is called once per frame
    void Update()
    {
        //エネルギーの表示非表示
        if(electricPower == maxElectricPower)
        {
            jetCage.SetActive(false);
        }
        else
        {
            jetCage.SetActive(true);
        }



        if (!canControl)//コントロール不可能状態なら、ボタン入力を受け付けない
        {
            return;
        }

        //ボタン読み込み
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pushButton.pushSpace = true;
        }



        //十字入力
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pushButton.pushLeft = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pushButton.pushRight = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pushButton.pushUp = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pushButton.pushDown = true;
        }
    }

    private void FixedUpdate()
    {
        //エネルギー回復
        if (playerRigidBody.velocity == Vector2.zero)
        {
            electricPower += 3;
            CheckMaxEletricPower();
        }

        //水平方向速度調整
        if(playerRigidBody.velocity.x < -0.1f)
        {
            playerRigidBody.velocity += new Vector2(0.1f, 0);
        }
        else if(playerRigidBody.velocity.x > 0.1f)
        {
            playerRigidBody.velocity -= new Vector2(0.1f, 0);
        }
        else
        {
            playerRigidBody.velocity -= Vector2.zero;
        }


        //チェーンを持っている場合
        if (pushButton.onChain)
        {
            pushButton.onChain = false;
            if (pushButton.pushUp)
            {
                pushButton.pushUp = false;
                playerTransForm.position += new Vector3(0, HorizonalSpeed, 0);
            }

            if (pushButton.pushDown)
            {
                pushButton.pushDown = false;
                playerTransForm.position += new Vector3(0, -HorizonalSpeed/2, 0);
            }

        }


        if (pushButton.pushRight)
        {
            pushButton.pushRight = false;
            playerTransForm.position += new Vector3(HorizonalSpeed, 0,0) ;

            if (playerRigidBody.velocity.x < -0.5f)//速度を殺す
            {
                playerRigidBody.velocity += new Vector2(0.5f, 0);
            }
        }

        if (pushButton.pushLeft)
        {
            pushButton.pushLeft = false;
            playerTransForm.position += new Vector3(-HorizonalSpeed, 0, 0);

            if (playerRigidBody.velocity.x > 0.5f)//速度を殺す
            {
                playerRigidBody.velocity -= new Vector2(0.5f, 0);
            }
        }

        if (pushButton.pushUp)
        {
            pushButton.pushUp = false;
            if (electricPower > 0)
            {
                electricPower--;

                if (playerRigidBody.velocity.y < VerticalMinimumGuaranteeSpeed)
                {
                    playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, VerticalMinimumGuaranteeSpeed);
                }

                playerRigidBody.velocity += new Vector2(0, VerticalSpeed);

                if (playerRigidBody.velocity.y > VerticalMaxSpeed)
                {
                    playerRigidBody.velocity -= new Vector2(0, VerticalSpeed);
                }
            }
        }
        else//上を押してないなら、急に減速
        {
            if (playerRigidBody.velocity.y > 6)
            {
                playerRigidBody.velocity -= new Vector2(0, 1f);
            }
        }

        if (pushButton.pushDown)
        {
            pushButton.pushDown = false;
        }

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Chain")
        {
            playerRigidBody.velocity = new Vector2(0, 0);
            canControl = true;
            pushButton.onChain = true;
        }
    }


    public void CheckMaxEletricPower()
    {
        if (electricPower > maxElectricPower)
        {
            electricPower = maxElectricPower;
        }
    }

}
