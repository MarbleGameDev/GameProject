using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetQuality : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Slider qualitySlider = GetComponent<Slider> ();
		qualitySlider.value = (float) QualitySettings.GetQualityLevel();
		print (QualitySettings.GetQualityLevel ());
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void setGraphicsQuality(){
		Slider qualitySlider = GetComponent<Slider> ();
		switch ((int)qualitySlider.value) {
		case 1:
			QualitySettings.SetQualityLevel(0, true);
			break;
		case 2:
			QualitySettings.SetQualityLevel(1, true);
			break;
		case 3:
			QualitySettings.SetQualityLevel(2, true);
			break;
		case 4:
			QualitySettings.SetQualityLevel(3, true);
			break;
		case 5:
			QualitySettings.SetQualityLevel(4, true);
			break;
		case 6:
			QualitySettings.SetQualityLevel(5, true);
			break;
		}
		int quality = QualitySettings.GetQualityLevel();
		print (quality);
	}
}
