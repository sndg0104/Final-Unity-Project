using UnityEngine;
using System.Collections;

public class Flyer : MonoBehaviour {

    public float speed = 6.0f;
    public float gravity = 1250.0f;
    private Vector3 moveDirection = Vector3.zero;


    public void FixedUpdate()
    {
        transform.Translate(Vector3.forward);
        
        moveDirection = new Vector3(0.0f, Input.GetAxis("UpDown"));
        float angle = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, angle);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        CharacterController controller = GetComponent<CharacterController>();
        controller.detectCollisions = true;
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
