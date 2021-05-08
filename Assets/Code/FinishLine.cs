using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(){
        gameManager.finishLine();
    }
}
