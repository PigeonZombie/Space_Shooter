using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

    public int lifetime;

	void Start () 
    {
        Destroy(gameObject, lifetime);
	}
	
}
