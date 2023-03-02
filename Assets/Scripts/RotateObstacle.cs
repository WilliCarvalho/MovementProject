using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacle : MonoBehaviour
{
    [SerializeField] private float velocity;
    private void Start()
    {
        velocity *= Time.deltaTime; //velocity = velocity * Time.deltaTime
    }
    // Update is called once per frame
    void Update()
    {        
        
        transform.Rotate(0, velocity, 0);
    }
}
