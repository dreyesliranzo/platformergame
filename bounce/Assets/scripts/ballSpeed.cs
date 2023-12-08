using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballSpeed : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public float jump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

       
        //player moves left
        if (Input.GetKey("a"))
        {
            newPosition.x -= speed;
        }

        //player moves right
        if (Input.GetKey("d"))
        {
            newPosition.x += speed;
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }


        transform.position = newPosition;
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("spikes"))
        {

            Destroy(gameObject);
            SceneManager.LoadScene(0);


        }
        if (collision.gameObject.tag.Equals("capsule"))
        {

            SceneManager.LoadScene(4);


        }
        if (collision.gameObject.tag.Equals("enemy"))
        {

            Destroy(gameObject);
            SceneManager.LoadScene(0);
            


        }
    }


}
