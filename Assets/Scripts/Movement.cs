using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float velocity;
    FallingCube instance;
    private int hittedObstacles;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * velocity;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * velocity;
        transform.Translate(moveX, 0, moveZ);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Hitted")
        {
            hittedObstacles++;
            Debug.Log($"You hitted {hittedObstacles} obstacles");
        }
    }
}
