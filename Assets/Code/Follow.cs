using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;    //Transform is a component not a datatype (?)
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
