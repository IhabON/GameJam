using UnityEngine;
using System.Collections;
using System.Timers;
using System;

public class SonicController : MonoBehaviour
{


    public Animator anim;
    public float speed = 8f;
    public Transform checkSol;
    bool touchelesol = false;

    float rayonsol = 0.3f;
    public LayerMask Sol;

    private Rigidbody2D rigi;
    /*bool adroite = true;
    bool checksSol = false;

    private void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();
        

    }


    void changedirection()
    {
        adroite = !adroite;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }
    */

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();
    }



    void FixedUpdate()
    {

        touchelesol = Physics2D.OverlapCircle(checkSol.position, rayonsol, Sol);
        anim.SetBool("Sol", touchelesol);
    }


    // Update is called once per frame
    void Update()
    {
        Timer timer = new Timer(1000);
        float timeLeft = 1.0f;
        timeLeft -= Time.deltaTime;


        float x = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(x));

        if (touchelesol && Input.GetButtonDown("Jump") )
        {
            rigi.AddForce(new Vector2(0, 700));

            //if (timeLeft<0.95 && Input.GetButtonDown("Jump"))
            //{
             //   rigi.AddForce(new Vector2(0, 700));
           // }
        }
       

            if (x > 0)
            {
                transform.Translate(x * speed * Time.deltaTime, 0, 0);
                transform.eulerAngles = new Vector2(0, 0);

            }
            if (x < 0)
            {
                transform.Translate(-x * speed * Time.deltaTime, 0, 0);
                transform.eulerAngles = new Vector2(0, 180);

            }


       bool y = Input.GetKeyDown("A");

        if (y==true)
            {
            Console.WriteLine(y);
            }

        }
    /*
    void OnGUI()
    {
        bool y;
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.A.ToString()))) { y = true; }
    }*/
}
