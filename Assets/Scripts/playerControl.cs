using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{

    public float speed = 4;
    public float jumpvelocity = 4;
    private bool sliding = false;
    public LayerMask playerMask;
    public SpriteRenderer animator;

    public UnityEngine.UI.Text scoretext;
    private int score;

    private Transform myTrans, tagGround;
    private Rigidbody2D myBody;

    private float hInput = 0;


    bool isGrounded = false; // only jump if he is on the ground

    void Start()
    {
        score = 0;
        UpdateScore();
        myBody = this.GetComponent<Rigidbody2D>();
        myTrans = this.transform;
        tagGround = GameObject.Find(this.name + "/tag_ground").transform;
    }
    void UpdateScore()
    {
        scoretext.text = "Score: " + score;
    }

    void FixedUpdate()
    {

        //isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);



        if (Input.GetButtonDown("Jump"))
            Jump();

#if !UNITY_ANDROID && !UNITY_IPHONE && !UNITY_BLACKBERRY && !UNITY_WINRT
        float input = Input.GetAxisRaw("Horizontal");

        if (input != 0)
        {
            Move(input);
        }
        else
        {
            if (sliding)
                return;

            Vector2 moveVel = myBody.velocity;
            moveVel.x = Mathf.Floor(moveVel.x);

            if (moveVel.x > 0)
            {
                moveVel.x -= speed;
            }
            else if (moveVel.x < 0)
            {
                moveVel.x += speed;
            }
            else
            {
                moveVel.x = 0;
            }

            myBody.velocity = moveVel;
        }
#else
		Move (hInput);
#endif
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.tag)
        {
            case "Ice":
                sliding = true;
                break;

            case "Coin":
                Destroy(collision.gameObject);
                score++;
                UpdateScore();
                break;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Ice":
                sliding = false;
                break;
        }
    }

    void Move(float horizontalInput)
    {
        Vector2 moveVel = myBody.velocity;

        if (Mathf.Abs(moveVel.x) < speed)
            moveVel.x += horizontalInput;
        else
            moveVel.x = speed * horizontalInput;

        myBody.velocity = moveVel;

        if (horizontalInput > 0)
            animator.flipX = false;
        else if (horizontalInput <= 0)
            animator.flipX = true;
    }

    public void Jump()
    {
        Vector2 jumpVel = myBody.velocity;
        if (jumpVel.y < 0.4)
            jumpVel.y += jumpvelocity;
        myBody.velocity = jumpVel;
    }

    public void startMoving(float horizontalInput)
    {
        hInput = horizontalInput;
    }
}
