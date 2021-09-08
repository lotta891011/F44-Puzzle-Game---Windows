using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelselect : MonoBehaviour
{
    public static int whichlevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.name == "Level 1")
        {
            whichlevel=1 ;
            
        }

        if (gameObject.name == "Level 2")
        {
            whichlevel=2 ;
            
        }

        if (gameObject.name == "Level 3")
        {
            whichlevel=3 ;
         
        }
        SceneManager.LoadScene("puzzle1");

    }
}
