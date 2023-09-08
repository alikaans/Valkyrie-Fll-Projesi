using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kazandin : MonoBehaviour
{
	
	public GameObject Kazandin;
	
    // Start is called before the first frame update
    void Start()
    {
        Kazandin.SetActive(false);
    }
	
	public void Sonraki(){
		SceneManager.LoadScene(2);
	}
	
	public void AnaMenu(){
		SceneManager.LoadScene(0);
	}	

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Kazandin.SetActive(true);
		}
	}
}
