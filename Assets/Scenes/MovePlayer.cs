using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update(){
        //Move Player Right
        if(Input.GetKey(KeyCode.LeftArrow)){
            this.transform.Translate (new Vector3 (-3f, 0f, 0f) * Time.deltaTime,Space.World);
		}    
        else if(Input.GetKey(KeyCode.RightArrow)){
            this.transform.Translate (new Vector3 (3f, 0f, 0f) * Time.deltaTime,Space.World);  
		}
        else if(Input.GetKey(KeyCode.UpArrow)){
            this.transform.Translate (new Vector3 (0f, 8f, 0f) * Time.deltaTime,Space.World);
		}
    }
}
