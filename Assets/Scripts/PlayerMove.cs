using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float yForce=500;
    public float SideForce = 700;

    private float middleOfScreenX;

    public void Start()
    {
        middleOfScreenX = Screen.width / 2;
    }

    void FixedUpdate()
    {



        GetComponent<Rigidbody>().AddForce(0, 0, yForce * Time.deltaTime);

      

        if (Input.GetKey("d"))
        {
            GoRight(1);
        }

        if (Input.GetKey("a"))
        {
            GoLeft(-1);
        }

        if (Input.touchCount >0 )
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x > middleOfScreenX )
            {
                GoLeft(1);
            }
            else if (touch.position.x < middleOfScreenX )
            {
                GoRight(-1);
            }
        }
        


        if (GetComponent<Transform>().position.y < 0.6f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    private void GoLeft(int ForDiviceSide)
    {
        rigidbody.AddForce(ForDiviceSide*SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    private void GoRight(int ForDiviceSide)
    {
        rigidbody.AddForce(ForDiviceSide*SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
