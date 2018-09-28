using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Konditions : MonoBehaviour {

    public bool ifBool;
    public int Value;

	// Use this for initialization
	void Start ()
    {
        if(ifBool == true)
        {
            print("ja");
        }
        
        {
            print("nej");
        }
        // != = inte lika med
        // == = lika med
        // <  = mindre än 
        // >  = större än
        // <= = mindre eller lika med
        // >= = större eller lika med
        // && = och
        // || = eller

        if (Value == 5)
        {
            print("tjo");
        }
        else if(Value == 4)
        {
            print("Mada mada");
        }
        else        
        {
            print("UMEGALUL");
        }

    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W))
        {
            print("du tryckte på knappen");
        }
	}
}
