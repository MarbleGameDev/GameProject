using UnityEngine;
using System.Collections;

public class AudioSettings : MonoBehaviour {
	GameObject optype;
	OptionsType options;
	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		optype = GameObject.Find ("Optiontypes");
		options = optype.GetComponent<OptionsType> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (options.audioEnabled) {
			gameObject.SetActive (true);
		} else {
			gameObject.SetActive (false);
		}
	}
}
