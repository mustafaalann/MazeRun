using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            SceneManager.LoadScene(0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            SceneManager.LoadScene(2);
            Cursor.visible = true;
        }
    }

    public void RestartGame(){
        Cursor.visible = false;
        SceneManager.LoadScene(1);
    }

    public void EndGame(){
        Cursor.visible = true;
        Application.Quit();
    }

}
