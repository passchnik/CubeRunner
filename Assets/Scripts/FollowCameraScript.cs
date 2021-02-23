using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraScript : MonoBehaviour
{
    public Transform _transformPlayer;
    public Vector3 _distanceCameraPlayer;
 
    void Update()
    {
        transform.position = _transformPlayer.position+_distanceCameraPlayer;
        
    }
}
