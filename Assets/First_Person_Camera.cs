using UnityEngine;
using System.Collections;

public class First_Person_Camera : MonoBehaviour 
{
	public GameObject target = null;

	void Start () 
	{
	
	}
	

	void Update () 
	{
		transform.position = target.transform.position;
		//stransform.LookAt (target);
	}



}
