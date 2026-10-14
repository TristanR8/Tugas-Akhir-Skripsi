using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D FrontWheelRB;
    [SerializeField] private Rigidbody2D BackWheelRB;
    [SerializeField] private Rigidbody2D BodyRB;
    [SerializeField] private float speed;
    [SerializeField] private float rotation;

    private float moveInput;
    private float buttonInput = 0f; // Input khusus dari tombol UI

    private void Update()
    {
        // Jika tombol UI sedang ditekan, gunakan input tombol UI. 
        // Jika tidak, gunakan input dari keyboard (A/D atau Panah).
        if (buttonInput != 0f)
        {
            moveInput = buttonInput;
        }
        else
        {
            moveInput = Input.GetAxisRaw("Horizontal");
        }
    }

    private void FixedUpdate()
    {
        FrontWheelRB.AddTorque(-moveInput * speed * Time.fixedDeltaTime);
        BackWheelRB.AddTorque(-moveInput * speed * Time.fixedDeltaTime);
        BodyRB.AddTorque(-moveInput * rotation * Time.fixedDeltaTime);
    }

    // Function ini akan dipanggil oleh script tombol UI
    public void SetMoveInput(float value)
    {
        buttonInput = value;
    }
}