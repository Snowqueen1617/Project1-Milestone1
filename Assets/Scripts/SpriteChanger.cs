//SpriteChanges
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    //Declare our variables
    public SpriteRenderer theRenderer;

    private Transform tf; //A variable to hold our Transform component

    public float maxScale; // Create a variable for the max we can scale in one frame draw


    // Start is called before the first frame update
    void Start()
    {
        //load the transform component into cariable

        Transform tf = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {

            gameObject.transform.position = Vector3.zero; // Vector3.zero is a preset value of (0,0,0)

        }
    }
}
