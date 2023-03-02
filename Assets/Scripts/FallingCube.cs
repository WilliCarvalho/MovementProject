using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCube : MonoBehaviour
{
    private Rigidbody rigidbody;
    private MeshRenderer meshRenderer;
    [SerializeField] float timeToFall;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;

        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToFall)
        {
            rigidbody.useGravity = true;
            meshRenderer.enabled = true;
        }
    }

}
