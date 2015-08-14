using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {
	
	public void ChangeToScene (string Scene) {
		Application.LoadLevel (Scene);
	}
}
