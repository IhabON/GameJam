using UnityEngine;
using System.Collections;

public class FallPlat: MonoBehaviour
{
    public Transform platform;
    public float fallDelay = 1f;
    public bool hasPlayed = false;

    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", fallDelay);
        }
    }

    void Fall()
    {
        rb2d.isKinematic = false;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hasPlayed == false)
        {
            hasPlayed = true;       
        }

        rb2d.isKinematic = false;    }

}
