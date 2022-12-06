using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    // Publics Vars
    public GameObject prefab;
    public int barrierSpeed;
    public Text points;
    public GameObject player;
    public Text TimeLeft;
    // Private Vars
    private GameObject obj;
    private int score = 0;
    private AudioSource audio;
    
    void Start () {
        // Crear una barrera
        Debug.Log("E: BarrierMovement");
        obj = Instantiate(prefab);
        audio = GetComponent<AudioSource>();
        obj.transform.position = new Vector3(Random.Range(4.00f, -4.00f), 1, 10);// -6
    }

    void Update()
    {
        // Movimiento de la barrera
        obj.transform.Translate(Vector3.left * barrierSpeed * Time.deltaTime);
        TimeLeft.text = "" + Time.timeSinceLevelLoad.ToString();

        if (obj.transform.position.z <= -13f)
        {
            // si la barerra paso la posición del jugador, te suma puntos. y destruye la barrera, y la duplica devuelta 
            //(le cambia la posición)
            Debug.Log("E: OBJ Destoy");
            score++;
            points.text = "Puntaje " + score.ToString();
            Destroy(obj);
            barrierSpeed++;
            audio.Play(0);
            obj = Instantiate(prefab);
            obj.transform.position = new Vector3(Random.Range(4.00f, -4.00f), 1, 10);
        }
        
        if(Time.timeSinceLevelLoad >= 40.00f)
        {
            SceneManager.LoadScene("YouWin");

        }
    }
}
