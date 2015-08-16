using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioSlider : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Slider qualitySlider = GetComponent<Slider> ();
		qualitySlider.value = (float)AudioListener.volume;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void setGraphicsQuality(){
		Slider qualitySlider = GetComponent<Slider> ();
		AudioListener.volume = qualitySlider.value;
	}
}
