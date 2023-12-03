using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yildiz : MonoBehaviour
{
	
	public GameObject yildizlar;
	
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("yildizaldi",0);
		PlayerPrefs.SetInt("ultrakarsi",0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter(Collider other)
	{	
		if(other.gameObject.tag == "yildiz")
		{
			Debug.Log("yildiz");
			PlayerPrefs.SetInt("yildizaldi",1);
			Destroy(yildizlar);
		}
		
		if(other.gameObject.tag == "ultrasonic"+PlayerPrefs.GetInt("ultrablock"))
		{
			Debug.Log("ultrasonic");
			PlayerPrefs.SetInt("ultrakarsi",1);
		}
		
		if(other.gameObject.tag == "duvar")
		{
			Debug.Log("dokunma");
			PlayerPrefs.SetInt("dokundu",1);
		}
	}
}
