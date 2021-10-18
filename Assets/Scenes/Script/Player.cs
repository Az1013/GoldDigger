using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float c_maxSpeed = 2f;
    public float c_speed = 0f;

    public float p_pv = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is starting");
        //GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            c_speed = c_speed * 1.01f;

            transform.position = transform.position + new Vector3(0.01f * c_speed, 0f, 0f);

            //c_speed *=
            //c_speed +=
            //c_speed -=

            //transform.position = new Vector3(0f, 0f, 1f);
            Debug.Log(" Toto ");
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            c_speed = c_speed * 1.01f;

            transform.position = transform.position + new Vector3(-0.01f * c_speed, 0f, 0f);

            //c_speed *=
            //c_speed +=
            //c_speed -=

            //transform.position = new Vector3(0f, 0f, 1f);
            Debug.Log(" Toto ");
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            c_speed = 1f;
        }

        if (c_speed > c_maxSpeed)
            c_speed = c_maxSpeed;

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            c_speed = c_speed * 1.01f;

            transform.position = transform.position + new Vector3(0f, 0.01f * c_speed, 0f);

            //c_speed *=
            //c_speed +=
            //c_speed -=

            //transform.position = new Vector3(0f, 0f, 1f);
            Debug.Log(" Toto ");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            c_speed = c_speed * 1.01f;

            transform.position = transform.position + new Vector3(0f, -0.01f * c_speed, 0f);

            //c_speed *=
            //c_speed +=
            //c_speed -=

            //transform.position = new Vector3(0f, 0f, 1f);
            Debug.Log(" Toto ");
        }
    }
}
