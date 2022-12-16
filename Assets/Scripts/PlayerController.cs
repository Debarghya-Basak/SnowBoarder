using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    public SurfaceEffector2D se2d;
    // [SerializeField] float dylanSpeed = 3f;
    public bool playerState = true;
    public float dylanSpeed = 3f;
    float torqueAmount = 1f;
    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        se2d = FindObjectOfType<SurfaceEffector2D>();
        se2d.speed = dylanSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        if(canMove){
            se2d.speed = 3 + (Input.GetAxis("Vertical")*4);

            if(Input.GetKey(KeyCode.LeftArrow)){
                rb2d.AddTorque(torqueAmount);  
            }
            else if(Input.GetKey(KeyCode.RightArrow)){
                rb2d.AddTorque(-torqueAmount);
            }
        }

        

        // transform.Rotate(new Vector3(0,0,Input.GetAxis("Vertical")));
    }
}
