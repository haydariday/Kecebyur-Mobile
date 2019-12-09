using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //cache
    [SerializeField] float moveSpeed = 1;
    Rigidbody2D myRigidBody;
    Transform transform;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFacingRight())
        {
            myRigidBody.velocity = new Vector2(moveSpeed, 0f);
        }
        else
        {
            myRigidBody.velocity = new Vector2(-moveSpeed, 0f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody.velocity.x)), 1f);
    }
    bool isFacingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.transform.position.y > transform.position.y+0.3f)
        {
            Destroy(gameObject);
        }
    }
}
