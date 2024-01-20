using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ultrasonic1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter(Collider other)
	{	
		if(other.gameObject.tag == "Player")
		{
			PlayerPrefs.SetInt("ultrasonicYakinlik",1);
			Debug.Log("1 boşluk kalmadan");
		}
	}
}
