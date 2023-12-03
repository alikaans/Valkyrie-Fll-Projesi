using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kaybettin : MonoBehaviour
{
	
	public GameObject Kaybettin;
	int sahne;
	
    // Start is called before the first frame update
    void Start()
    {
		int sahne = SceneManager.GetActiveScene().buildIndex;
        Kaybettin.SetActive(false);
    }
	
	public void Tekrar(){
		SceneManager.LoadScene(sahne);
	}
	
	public void AnaMenu(){
		SceneManager.LoadScene(0);
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Kaybettin.SetActive(true);
		}
	}
}
