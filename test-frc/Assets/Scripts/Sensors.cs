using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sensors : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
    }
	
	public void HandleInputData(int val)
	{
		if(val==0)
		{
			Debug.Log("0");
			PlayerPrefs.SetInt("gyroyon",0);
			Debug.Log(PlayerPrefs.GetInt("gyroyon"));
		}
		if(val==1)
		{
			Debug.Log("1");
			PlayerPrefs.SetInt("gyroyon",1);
			Debug.Log(PlayerPrefs.GetInt("gyroyon"));
		}
	}
	
	
	
    // Update is called once per frame
    void Update()
    {

    }
}
