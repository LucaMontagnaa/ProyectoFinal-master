using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    private int movementSpeed = 5;

	void Start () {
        Debug.Log("E: PlayerMovement");
	}

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        

        
    }
}
