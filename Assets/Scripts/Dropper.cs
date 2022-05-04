using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log($"Current time: {Time.time}, Elapsed time: {Time.time - startTime}");
        if (Time.time > timeToWait)
        {
            Debug.Log($"{gameObject.name}: {timeToWait} seconds has elapsed.");
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
