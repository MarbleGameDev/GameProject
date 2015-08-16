﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResolutionSettings : MonoBehaviour {

	Resolution[] resolutions;

	[SerializeField] GameObject buttonPrefab;
	[SerializeField] Transform videoPanel;
	// Use this for initialization
	void Start () {
		resolutions = Screen.resolutions;
		for (int i = 0; i < resolutions.Length; i++) {
			GameObject button = (GameObject)Instantiate (buttonPrefab);
			button.GetComponentInChildren<Text>().text = ResToString(resolutions[i]);
			int index = i;
			button.GetComponent<Button>().onClick.AddListener(
				() => {SetResolution (index);}
				);
			button.transform.SetParent(videoPanel);
		}
	}

	void SetResolution (int index){
		Screen.SetResolution (resolutions [index].width, resolutions [index].height, false);
	}

	string ResToString (Resolution res){
		return res.width + " x " + res.height;
	}
}
