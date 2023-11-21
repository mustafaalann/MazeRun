using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            SceneManager.LoadScene(1);
            Cursor.visible = true;
        }
    }

    public void RestartGame(){
        Cursor.visible = false;
        SceneManager.LoadScene(0);
    }

    public void EndGame(){
        Cursor.visible = true;
        Application.Quit();
    }

}
