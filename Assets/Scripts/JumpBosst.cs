using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBosst : MonoBehaviour
{
    public float JumpForce = 700f;
    public Rigidbody PlayerRigidbody;

    private void OnTriggerEnter()
    {
        Jump();
    }

    private void Jump()
    {
        PlayerRigidbody.AddForce(0, JumpForce, 0, ForceMode.VelocityChange);
    }



}
