using UnityEngine;

public class test : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 v = new Vector2(1,1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        //rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            Vector2 temp = transform.position;
            temp.x += 0.01f;
            transform.position = temp;
        }

        //if (Input.GetButtonDown("Jump"))
        //{
        //    v.x += 1;
        //    v.y -= 1;

        //    //v.x += 1;
        //    // v.y -= 1;
        //    //temp.x = temp.x + 1;

        //    //transform.position = v;
        //    //rb.AddForce(new Vector2(1, 1) * 3, ForceMode2D.Impulse);
        //}
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    v.x -= 1;
        //    v.y -= 1;
        //}
        //transform.localScale = v;
    }
}
