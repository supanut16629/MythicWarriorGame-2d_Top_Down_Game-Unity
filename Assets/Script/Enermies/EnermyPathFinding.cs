using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyPathFinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.5f;
    private Rigidbody2D rb;
    private Vector2 moveDir;
    private KnockBack knockback;

    private void Awake()
    {
        knockback = GetComponent<KnockBack>();
        rb = GetComponent<Rigidbody2D>();   
    }

    private void FixedUpdate()
    {
        if (knockback.GettingKnockBack) { return; }
        rb.MovePosition(rb.position + moveDir * (moveSpeed * Time.fixedDeltaTime));
    }

    public void MoveTo(Vector2 targetPosition)
    {
        moveDir = targetPosition;
    }
}
