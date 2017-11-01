using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request : MonoBehaviour {
    public string url = "https://upload.wikimedia.org/wikipedia/en/thumb/0/09/AshXYanime.png/250px-AshXYanime.png";

    // Use this for initialization
    void Start () {
        WWW www = new WWW(url);
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = www.texture;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
