using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving: MonoBehaviour
{
    public float steering;
    public int speed;
    public float acceleration;
    public float fb;
    public float rl;
    public float deacceleration;
    public float flip;
    public string Horizontal;
    public string Vertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fb = Input.GetAxis(Vertical);
        rl = Input.GetAxis(Horizontal);
        flip = Input.GetAxis("Jump");
        if (flip == 1)
        {
            gameObject.transform.eulerAngles.Set(0, 0, 0);
        }
        if (fb > 0 && acceleration <= 5)
        {
            acceleration += (fb / 12);
        }else if (fb < 0 && acceleration >= -.5)
        {
            acceleration += (fb / 2);
        }else
        {
            acceleration /= deacceleration;
        }
        if (steering > 20)
        {
            steering = 20;
        }else if (steering < -20)
        {
            steering = -20;
        }
        else if (steering <= 20)
        {
            steering += rl / 5;
        }
        else if (steering >= -20)
        {
            steering += rl / 5;
        }
        if (acceleration > 0 && acceleration < .0001)
        {
            acceleration = 0;
        }else if (acceleration < 0 && acceleration > -.0001)
        {
            acceleration = 0;
        }
        else if (acceleration > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * acceleration * speed);
            if (acceleration > .1)
            {
                transform.Rotate(Vector3.up * Time.deltaTime * steering);
            }
        }
        else if(acceleration < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * acceleration * speed);
            if (acceleration < .1)
            {
                transform.Rotate(Vector3.up * Time.deltaTime * steering * -1);
            }
        }
    }
}
