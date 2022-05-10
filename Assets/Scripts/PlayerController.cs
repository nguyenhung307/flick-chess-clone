using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //tao toc do
    public float speed = 20;
    //toc do di chuyen them
    public float turnSpeed = 40;
    // tao ham input dieu khien player (edit/Project Settings/Input Manager/ Axes)
        // horizontal di chuyen trai phai
        // Vertical di chuyen len xuong
    public float horiInput;
    public float VertiInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horiInput = Input.GetAxis("Horizontal");
        VertiInput= Input.GetAxis("Vertical");

        //tien phia truoc
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VertiInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horiInput);        
        transform.Rotate(Vector3.up, horiInput * turnSpeed * Time.deltaTime);
    }
}
