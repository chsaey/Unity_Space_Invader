using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    GameObject b;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, .1f, 0);
        b = gameObject;
        Destroy(b, 1);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(b);
        }


    }
}

