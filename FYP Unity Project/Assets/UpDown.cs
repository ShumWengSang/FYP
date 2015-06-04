using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {

    private Transform theTransform;
	// Use this for initialization
	void Start () {
        theTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        theTransform.position += new Vector3(0, 1, 0) * Time.deltaTime;
	}
}
