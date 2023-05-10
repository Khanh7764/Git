using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    private GameObject obj;
   public float oldPosition;
   //public float minY;
   //public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = 55;
        //minY = -8;
        //maxY = 8;

    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" )
        {
           obj.transform.position = new Vector3(oldPosition, Random.Range(-7,7), 0);
        }
        
        
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            Debug.Log("Khanh");
        }
    }*/
}
