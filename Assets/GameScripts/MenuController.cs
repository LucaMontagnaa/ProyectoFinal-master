using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public Button btn1;
    public Text sufb;
    private int count = 3;
    void Start() {
        Button btn = btn1.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        StartCoroutine(Coroutine());
        sufb.text = "Empezando en";
    }
    IEnumerator Coroutine()
    {
        for (int i = 4; i > 0; i--)
        {
            sufb.text = i.ToString();
            Debug.Log(i.ToString());
            yield return new WaitForSeconds(1   );
        }
        SceneManager.LoadScene("GameScene");
    }
}

