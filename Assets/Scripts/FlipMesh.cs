﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FlipMesh : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void flip(GameObject objec)
    {
        Mesh mesh = objec.GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
}
