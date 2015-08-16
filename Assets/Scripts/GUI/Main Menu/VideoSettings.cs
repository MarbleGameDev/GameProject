using UnityEngine;
using System.Collections;

public class VideoSettings : MonoBehaviour {
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
		if (options.videoEnabled) {
			gameObject.SetActive (true);
		} else {
			gameObject.SetActive (false);
		}
	}
}
