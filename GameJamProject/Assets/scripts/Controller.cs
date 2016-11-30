using UnityEngine;
using System.Collections;
using System;
public class Controller : MonoBehaviour
{


    public Animator anim;
    public float speed = 8f;

    public Transform checkSol;
    bool toucheLeSol = false;
    float rayonSol = 0.3f;
    public LayerMask Sol;
    private Rigidbody2D rigi;
    public float y;

    private void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();


    }

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
 void FixedUpdate()
    {

        toucheLeSol = Physics2D.OverlapCircle(checkSol.position, rayonSol, Sol);
        anim.SetBool("Sol", toucheLeSol);
    }
    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(x));

        if (toucheLeSol && Input.GetButtonDown("Jump"))
        {
            rigi.AddForce(new Vector2(0, 500));
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


        if (Input.GetButtonDown("Fire1") )
        {
            anim.SetFloat("y", Mathf.Abs(1));

        }

        if (Input.GetButtonUp("Fire1"))
        {
            anim.SetFloat("y", Mathf.Abs(0));

        }

    }
    }
