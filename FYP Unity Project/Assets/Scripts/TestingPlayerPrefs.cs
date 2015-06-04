using UnityEngine;
using System.Collections;

public class TestingPlayerPrefs : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        if (PlayerPrefs.HasKey("Testing"))
        {
            Debug.Log("I have key for player prefs");
        }
        else
        {
            PlayerPrefs.SetFloat("Testing", 1);
        }
        PlayerPrefs.Save();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
