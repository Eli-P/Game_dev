using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAV : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float range;
    public GameObject player;
    public float playerDist;
    public float x;
    public float y;
    public float pX;
    public float pY;
    public float mX;
    public float mY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mX = transform.position.x;
        mY = transform.position.y;
        pX = player.transform.position.x;
        pY = player.transform.position.y;
        if (mX - pX != 0)
        {
            if (mX - pX < 0)
            {
                x = pX - mX;
            }
            else
            {
                x = mX - pX;
            }
        }
        else
        {
            x = 0;
        }
        if (mY - pY != 0)
        {
            if (mY - pY < 0)
            {
                y = pY - mY;
            }
            else
            {
                y = mY - pY;
            }
        }
        else
        {
            x = 0;
        }
        x *= x;
        y *= y;
        
    }
}
