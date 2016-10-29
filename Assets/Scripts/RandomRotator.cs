using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

    public float tumble;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Angular velocity: how fast it is rotating 
        // insideUnitSphere: gives a random Vector3 that can be used for a rotation
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
	
}
