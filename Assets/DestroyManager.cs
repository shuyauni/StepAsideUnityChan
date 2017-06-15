using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyManager : MonoBehaviour {
    private GameObject myCameraPos;

    // Use this for initialization
    void Start () {
        this.myCameraPos = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
        if (this.myCameraPos.transform.position.z >= this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
        
	}
}
