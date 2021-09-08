using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public Sprite stage2Image;
    public Sprite stage3Image;
    // Start is called before the first frame update
    void Start()
    {
        if (levelselect.whichlevel == 2)
        {
            GetComponent<SpriteRenderer>().sprite = stage2Image;
        }

        if (levelselect.whichlevel == 3)
        {
            GetComponent<SpriteRenderer>().sprite = stage3Image;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
