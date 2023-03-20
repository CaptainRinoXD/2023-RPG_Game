using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D MyRigidBody;
    private Animator MyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        MyRigidBody = GetComponent<Rigidbody2D>();
        MyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //update base on the frame rate of the machine it run on (variable)
    }

    // Because update is per frame, fix update is recommend as it has it fixed time
    // Fix update call for update 50 time per second
    private void FixedUpdate()
    {
        MyRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * moveSpeed * Time.fixedDeltaTime; //Make character move

        MyAnimator.SetFloat("MoveX", MyRigidBody.velocity.x);
        MyAnimator.SetFloat("MoveY", MyRigidBody.velocity.y);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            MyAnimator.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
            MyAnimator.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }
    
}
