using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {    
    public GameObject Enemy, Bullet;
    Vector2 enemyPos, playerBullet;
    float x = -5.5f;
    float y = 4f;
    // Use this for initialization    
    void Start()
    {
        for (float t = 0; t < 5; t++)
        {
            for (float i = 0; i < 12; i++)
            {
                enemyPos = new Vector2(x+i,y-t);
                Instantiate(Enemy, enemyPos, Quaternion.identity);
            }

        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerBullet = new Vector2(transform.position.x, transform.position.y + 1);
            Instantiate(Bullet, playerBullet, Quaternion.identity);      

        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(-.05f,0,0);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(.05f, 0, 0);

        }
    }
}
