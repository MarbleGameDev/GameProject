using UnityEngine;
using System.Collections;

public class OptionsMenu : MonoBehaviour {
	public bool isEnabled = false;
	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void toggleWindow(){
		gameObject.SetActive (!isEnabled);
		isEnabled = !isEnabled;
	}

	public void setQuality(int numValue){

	}
}
