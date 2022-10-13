using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip LuckyClip;
    public AudioClip KillerClip;

    public GameManager gm;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        //Debug.Log("xMove:" + xMove);
        transform.Translate(xMove * speed * Time.deltaTime, 0, 0);
        
    }
  
        
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lucky")
        {
            

            gm.IncrementScore(1);
            gm.PlaySound(LuckyClip);
            Destroy(collision.gameObject);
        }


        if (collision.gameObject.tag == "Killer")
        {
            gm.PlaySound(KillerClip);
            Destroy(gameObject);
            Debug.Log("Triggered");
        }


    }
}
