using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kazandin : MonoBehaviour
{
	
	public GameObject Kazandin;
	
    // Start is called before the first frame update
    void Start()
    {
        Kazandin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Kazandin.SetActive(true);
		}
	}
}
