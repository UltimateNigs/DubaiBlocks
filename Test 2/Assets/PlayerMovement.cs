using UnityEngine; 
using System.Collections;
public class PlayerMovement : MonoBehaviour { 
	public float moveSpeed;  
<<<<<<< HEAD
=======
	private float MaxSpeed=20f;
>>>>>>> 8b7321ed5eb3cf79fe1e773e56b0ac0e8be62586




	 
	void Start () {      
<<<<<<< HEAD
		moveSpeed = 40f;
=======
		moveSpeed = 2f;
>>>>>>> 8b7321ed5eb3cf79fe1e773e56b0ac0e8be62586

	}          // Update is called once per frame    


	void Update () {   

		transform.Translate (moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
	} }