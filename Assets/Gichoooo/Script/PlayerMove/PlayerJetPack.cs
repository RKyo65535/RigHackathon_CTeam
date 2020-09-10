using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJetPack : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;
    private Transform playerTransForm;

    class PushButton
    {
        public bool pushZ;
        public bool pushX;
        public bool pushC;
        public bool pushSpace;
        public bool pushLeft;
        public bool pushRight;
        public bool pushUp;

    }


    // Start is called before the first frame update
    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        playerTransForm = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //

        
    }

    private void FixedUpdate()
    {
        
    }

}
