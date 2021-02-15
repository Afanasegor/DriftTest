using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    public Transform car;

    void Start()
    {
        transform.position = new Vector3(car.position.x, transform.position.y, car.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(car.position.x, transform.position.y, car.position.z);
    }
}
