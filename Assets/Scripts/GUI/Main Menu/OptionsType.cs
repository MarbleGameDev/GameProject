using UnityEngine;
using System.Collections;

public class OptionsType : MonoBehaviour {
	public bool audioEnabled, videoEnabled, controlsEnabled;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setSubWindow(string subType){
		switch (subType) {
		case "audio":
			audioEnabled = true;
			videoEnabled = false;
			controlsEnabled = false;
			break;
		case "video":
			audioEnabled = false;
			videoEnabled = true;
			controlsEnabled = false;
			break;
		case "controls":
			audioEnabled = false;
			videoEnabled = false;
			controlsEnabled = true;
			break;
		}
	}
}
