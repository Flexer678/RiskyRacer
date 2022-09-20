using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEFTLANE : MonoBehaviour
{   
    public GameObject left_line;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++){
            GameObject clone =  Instantiate(left_line);
            clone.transform.position = new Vector3(i*3,0f,0f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
