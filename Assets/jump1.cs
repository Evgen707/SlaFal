using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump1 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 50f;

    public bool isGround;
    public float rayDistance = 0.6f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GroupCheck();
    }

    public void GroupCheck()
    {
        RaycastHit2D hit = Physics2D.Raycast(rb.position, Vector2.down, rayDistance, LayerMask.GetMask("Ground"));

        if (hit.collider != null)
        {
            isGround = true;

        }
        else
        {
            isGround = false;
        }
    }

    public void JumpButton()
    {
        if(isGround)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
