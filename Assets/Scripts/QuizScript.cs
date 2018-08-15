using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizScript : MonoBehaviour {
    public Transform lever;
    public Transform top;
    public Transform bottom;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void generateOptions(GameObject touchedObject)
    {
        print(touchedObject.name);
        int i = Random.Range(0, 1);
        if (i==0)
        {
           top.GetComponent<TextMesh>().text=touchedObject.name; 
        }
        else if (i == 1)
        {
            bottom.GetComponent<TextMesh>().text = touchedObject.name;
        }
    }
}
