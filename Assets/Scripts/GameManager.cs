//GameManager
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objectToDeativate;
    public SpriteChanger componentToDisable;

    //Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            componentToDisable.enabled = !componentToDisable.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            objectToDeativate.SetActive(!objectToDeativate.activeInHierarchy);
        }
    }
}