using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundcolor : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        

        if(levelselect.whichlevel == 2)
        {
            Color back1= new Color(0.8941f, 0.589f, 0.355f, 0f);
            cam.backgroundColor = back1;
        }

        if (levelselect.whichlevel == 3)
        {
            Color back2 = new Color(0.5991f, 0.6862f, 0.1686f, 0f);
            cam.backgroundColor = back2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}