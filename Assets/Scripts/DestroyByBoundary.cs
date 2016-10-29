using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

    // When the object stops touching the trigger
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
