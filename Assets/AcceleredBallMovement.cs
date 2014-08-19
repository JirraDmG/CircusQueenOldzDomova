using UnityEngine;
using System.Collections;

public class AcceleredBallMovement : MonoBehaviour {

    public float BallSpeed = 80.0F;
    public bool debug;

	// Use this for initialization
	// Update is called once per frame
	void Update () 
    {
        
        Vector3 dir = Vector3.zero;


    //remap axis to position of the device
        if (debug)
            {
            dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            }
        else
            {
            dir.x = -Input.acceleration.y;
            dir.z = -Input.acceleration.x;
            }
        

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

    //define moving position per time not per frame

        dir *= Time.deltaTime;

    //add force to the object

        transform.rigidbody.AddForce(dir * BallSpeed);

	}
    
    //save start position of the object 

    private Vector3 startPosition; 
    
    void Start()
        {
            startPosition = this.transform.position;
        }

    //reset position to start

    public void Restart()
        {
            this.transform.position = startPosition; 
        }

}
