using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocity = 10;
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * velocity;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * velocity;
        transform.Translate(moveX, 0, moveZ);
    }
}
