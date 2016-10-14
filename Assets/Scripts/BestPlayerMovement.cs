using UnityEngine;
using System.Collections;

public class BestPlayerMovement : MonoBehaviour {

	// Use this for initialization
	public Rigidbody rb;
	private Camera cam;
	public float speed;
	public int angSpeed = 40;

	void Start () {
		rb = this.GetComponent<Rigidbody>();
		cam = Camera.main;
	}

	// Update is called once per frame
	void Update () {
		float vSped = Input.GetAxis("Vertical");
		rb.transform.Rotate(0.0f, Input.GetAxis("Horizontal") * Time.deltaTime * angSpeed, 0.0f);
		rb.AddRelativeForce(new Vector3(0.0f, 0.0f, vSped * speed));
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rb.velocity = new Vector3(0.0f,0.0f,0.0f);
		}
	}
}

