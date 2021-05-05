using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector2 Movement;
    private float Movespeed = 7f;

    public Rigidbody2D rb;
    public Camera Camera;

    private float HorizontalDirection = 0;
    private float VerticalDirection = 0;

    public int QuantMadeira = 0, QuantPedra = 0, QuantGrama = 0;

    public void Awake()
    {
    }

    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        HorizontalDirection = Input.GetAxisRaw("Horizontal");
        VerticalDirection = Input.GetAxisRaw("Vertical");

        if (HorizontalDirection < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (HorizontalDirection > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0f, 180);
        }

        if (VerticalDirection < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (VerticalDirection > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
    }

    void FixedUpdate()
    {
        Camera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10);
        rb.MovePosition(rb.position + Movement * Movespeed * Time.fixedDeltaTime);
        Vector2 pp = new Vector2(rb.transform.position.x, (rb.transform.position.y + 1.3f));
    }
}
