using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Target;

    private Vector3 velocity;

    private void Awake()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y,Target.position.z - 30f);
        
    }

    private void Update()
    {        
        //if (!MainMenu.IsGameStarted) return;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(Target.position.x, Target.position.y, Target.position.z - 30f), 30f);
        //transform.position = Vector3.SmoothDamp(transform.position, Target.position, ref velocity, 0.18f, 10f);
    }
}
