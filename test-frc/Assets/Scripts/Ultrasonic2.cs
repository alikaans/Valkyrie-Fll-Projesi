using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ultrasonic2 : MonoBehaviour
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
			PlayerPrefs.SetInt("ultrasonicYakinlik2",2);
			Debug.Log("boşluk kalmadan");
		}
	}
}
