using UnityEngine;

public class Collide : MonoBehaviour
{
    public OrbScript movement;
    //public string message;
    public void OnCollisionEnter(Collision collsionInfo) {
        if(collsionInfo.collider.name=="Wall"){
            Debug.Log("wow you're bad at this");
        }

        if(collsionInfo.collider.name=="Ground"){
            Debug.Log("cube has landed");
        }

        if(collsionInfo.collider.tag=="Obstacle"){
            Debug.Log("you hit an obstacle");
            GetComponent<OrbScript>().enabled=false;
            // FindObjectOfType<Score>().gameOverUpdate();
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
