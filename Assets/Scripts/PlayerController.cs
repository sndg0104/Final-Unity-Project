using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float y;
    public const float MIN_X = -15;
    public const float MAX_X = 15;
    public const float MIN_Z = -10;
    public const float MAX_Z = 10;
    private float speed = 20;
    private void Awake()
    {
        y = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () 
    {
        KeyboardMovement();
        CheckBounds();
	}
    private void KeyboardMovement()
    {
        //GetAxis is checking the direction (references to the arrow keys or whatever other tags(strings))
        float dx = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float dz = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(new Vector3(dx, y, dz));
    }
    //keep us inside the world and not fall off the edge
    private void CheckBounds()
    {
        float x = transform.position.x;
        float z = transform.position.z;
        x = Mathf.Clamp(x, MIN_X, MAX_X);
        z = Mathf.Clamp(z, MIN_Z, MAX_Z);
        transform.position = new Vector3(x, y, z);
    }
}
