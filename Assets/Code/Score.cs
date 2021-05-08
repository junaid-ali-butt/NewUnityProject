using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    //public RigidBody rb;
    // Update is called once per frame
    void Update()
    {
        score.text = (player.position.z + 39).ToString("0");
        if(player.position.y < -1f){
            score.text = "Game Over";
        }
    }

    // public void gameOverUpdate(){
    //     Debug.Log("Called");
    //     score.text = "Game Over";
    // }

    // public void OnCollisionEnter(Collision info) {
    //     if(info.collider.tag=="Obstacle"){
    //         score.text = "Game Over";
    //     }
    // }
}
