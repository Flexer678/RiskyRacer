using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameObject : MonoBehaviour
{
    // Start is called before the first frame update
    public gameObject left_line;
    void Start()
    {
        for(int i = 0; i < 10; i++){
            GameObject clone = Instantiate(left_line);
            clone.transform.position = new vector2(i*3, i+1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


//printing
//vriables 
//data types
//while loop
//for loop
//if statements
//try and except
