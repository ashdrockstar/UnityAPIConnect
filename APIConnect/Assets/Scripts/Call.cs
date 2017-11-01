using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
public class Call : MonoBehaviour {

    private string url = "http://pokeapi.co/api/v2/pokemon/";
    private JsonData data;
    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        data = JsonMapper.ToObject(www.text);
        Debug.Log(data["results"][0][1]);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
