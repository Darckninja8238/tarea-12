using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    public float horizontal;
    public float speedX;
    public float SpeedY;
    private Rigidbody2D _comprigidbody2D;
    public float vertical;
    private void Awake()
    {
        _comprigidbody2D = GetComponent<Rigidbody2D>();
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        _comprigidbody2D.velocity = new Vector2(speedX * horizontal, SpeedY*vertical);
    }
}
