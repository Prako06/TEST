using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    bool facingright;
    // Start is called before the first frame update
    void Start()
    {
        facingright = true;
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);
        transform.position += direction * speed * Time.deltaTime;
        if (horizontal > 0 && !facingright)
        {
            flip();
        }

        else if (horizontal < 0 && facingright)
        {
            flip();
        }
    }
    void flip()
    {
        facingright = !facingright;
        Vector3 thescale = transform.localScale;
        thescale.x *= -1;
        transform.localScale = thescale;
    }
}
