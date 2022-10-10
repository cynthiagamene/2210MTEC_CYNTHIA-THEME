using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public GameManager gm;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        //remember to fix this 
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");

        //Debug.Log("xMove:" + xMove");

        transform.Translate(xMove * speed * Time.deltaTime, 0, 0);

    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Coin")
        {
            gm.IncrementScore(1);
            Destroy(collision.gameObject);
        }
        {
            if (collision.gameObject.tag == "Hazard")
            {
                Destroy(gameObject);
            }

        }
    }
}
