using UnityEngine;

public class OrbScript : MonoBehaviour 
{
    public Rigidbody rb;
    public float forwardForce=500f;
    public float sidewayForce=250f;
    public float upwardForce=250f;
    public float altitude=-1f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Yo is this on?");
        //rb.useGravity = false;
        //rb.AddForce(0,200,500);
    }

    //Update is called once per frame
    // void Update()
    // {
    //     rb.AddForce(0,0,forwardForce * Time.deltaTime);

    //     if(Input.GetKey("d")){
    //         rb.AddForce(sidewayForce * Time.deltaTime,0,0);
    //     }

    //     if(Input.GetKey("a")){
    //         rb.AddForce(-sidewayForce * Time.deltaTime,0,0);
    //     }

    //     if(Input.GetKey("w")){
    //         rb.AddForce(0,upwardForce,0);
    //     }
    // }

    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sidewayForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sidewayForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("w")){
            rb.AddForce(0,upwardForce,0);
        }

        if(rb.position.y < altitude){
            // FindObjectOfType<Score>().gameOverUpdate();              //Experiment
            //FindObjectOfType<GameManager>().endGame();                //Restarts Level
            FindObjectOfType<GameManager>().gameOverByFall();
        }
    }

    // void FixedUpdate()
    // {
    //     rb.AddForce(0,0,forwardForce);

    //     if(Input.GetKey("d")){
    //         rb.AddForce(sidewayForce,0,0);
    //     }

    //     if(Input.GetKey("a")){
    //         rb.AddForce(-sidewayForce,0,0);
    //     }

    //     if(Input.GetKey("w")){
    //         rb.AddForce(0,upwardForce,0);
    //     }
    // }
}
