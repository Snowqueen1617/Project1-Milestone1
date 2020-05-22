using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    //Declare our variables
    public SpriteRenderer theRenderer;
    public Color spriteColor;

    private Transform tf; //A variable to hold our Transform component

    // Start is called before the first frame update
    void Start()
    {
        //Change the color from our color picker so the alpha is 1
        spriteColor.a = 1.0f;

        // As long as theRenderer has been set
        if (theRenderer != null) 
        {
            //Change the color of our SpriteRenderer component
            theRenderer.color = spriteColor;
        }

        //Get the transform component
        tf = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
  
        tf.position += Vector3.up * 0.1f;
        //tf.position = new Vector3(0, 0, 0);
    }
}
