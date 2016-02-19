using UnityEngine; 
using System.Collections;
public class PlayerMovement : MonoBehaviour { 
	public float moveSpeed;  




	 
	void Start () {      
		moveSpeed = 40f;

	}          // Update is called once per frame    


	void Update () {   

		transform.Translate (moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
	} }