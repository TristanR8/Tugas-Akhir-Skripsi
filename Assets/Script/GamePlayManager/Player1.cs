using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float rotateSpeed = 5f;
    public LayerMask groundLayer;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 3f, groundLayer);

        if (hit.collider != null)
        {
            float angle = Mathf.Atan2(hit.normal.x, hit.normal.y) * Mathf.Rad2Deg;

            Quaternion targetRot = Quaternion.Euler(0, 0, -angle);

            transform.rotation = Quaternion.Lerp(
                transform.rotation,
                targetRot,
                rotateSpeed * Time.deltaTime
            );
        }
    }
}
