using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameoverflag=false;
    public float restartDelay=1f;
    public GameObject completelevelUI;
    public GameObject gameoverUI;
    
    public void finishLine(){
        completelevelUI.SetActive(true);
    }
    
    public void gameOverByFall(){
        gameoverUI.SetActive(true);
        // Invoke("jumpToMain",-5f);
    }

    public void endGame(){
        if(gameoverflag==false){
            gameoverflag=true;
            Debug.Log("Game Over");
            Invoke("restart",restartDelay);
            //return gameoverflag;
        }
    }

    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // void jumpToMain(){
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex);
    // }
}
