using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{	
	public float horizontalMovement;
	public float verticalMovement;
	public float playerSpeed;
	public bool isMoving;

	void Start () 
	{
	
	}
	

	void Update () 
	{
	
		horizontalMovement = Input.GetAxis ("Horizontal");
		verticalMovement = Input.GetAxis ("Vertical");
		//var distance = horizontalMovement * 10 * Time.deltaTime;
		if (horizontalMovement != 0 | verticalMovement != 0) 
		{
		 	isMoving = true;

			transform.Translate (-verticalMovement, 0 , horizontalMovement);

			//transform.Translate (Vector3.forward * distance);

			isMoving = false;
		}
		 
	}
}
