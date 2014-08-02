using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{
    bool facingRight = true;
    bool jump = false;
    bool action = false;

    Animator anim;

    bool grounded = false;
    public Transform groundCheck;
    public LayerMask whatIsGround;

    public float jumpForce = 300;
    public float maxSpeed = 10f;

    GameObject game;

    void Start()
    {
        anim = GetComponent<Animator>();
        game = GameObject.Find("State");
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonUp(0)) && grounded && !game.transform.GetComponent<State>().GetDead())
            jump = true;
        if (transform.position.y <= -1.5)
        {
            game.transform.GetComponent<State>().Dead();
            anim.SetTrigger("dead");
        }
    }

    void FixedUpdate()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, whatIsGround);
        rigidbody2D.velocity = new Vector2(1 * game.transform.GetComponent<State>().GetSpeed(), rigidbody2D.velocity.y);

        if (jump)
        {
            anim.SetTrigger("jump");
            rigidbody2D.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
        if (action)
        {
            anim.SetTrigger("action");
            action = false;
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
