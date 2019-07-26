using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Die", 1f);
	}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
    void Die()
    {
        Destroy(gameObject);
    }
}
