using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

    public GameObject player;
	void Start () {
		
	}
	
    void OnCollisionEnter(Collision coll)
    {
        Debug.Log(coll.gameObject.name);
        if(coll.gameObject.name == "Pinchos(Clone)")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    
}
