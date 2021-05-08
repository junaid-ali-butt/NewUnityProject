using UnityEngine;
using UnityEngine.SceneManagement;
public class JumpToStart : MonoBehaviour
{
    public void jumpToStart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex);
    }
}
