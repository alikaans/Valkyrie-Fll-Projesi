using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kazandin : MonoBehaviour
{
	
	public GameObject Kazandin;
	public Image resim;
	public Image resim2;
	int yildiz;
	
	void Update()
	{
		yildiz = PlayerPrefs.GetInt("yildiz");
		//Debug.Log(yildiz);
	}
	
    void Start()
    {
		//PlayerPrefs.DeleteKey("yildiz");
        Kazandin.SetActive(false);
    }
	
	public void Sonraki(){
		Time.timeScale = 1f;
		seviyeyonetici.seviye2 = true;
		SceneManager.LoadScene(2);
	}
	
	public void AnaMenu(){
		SceneManager.LoadScene(0);
		Time.timeScale = 1f;
		seviyeyonetici.seviye2 = true;
	}	

	private void OnTriggerEnter(Collider other)
	{	
		if(other.gameObject.tag == "Player")
		{
			resim.color = Color.yellow;
			Kazandin.SetActive(true);
			Time.timeScale = 0f;
			if(PlayerPrefs.GetInt("yildizaldi")==1)
			{
				yildiz+=1;
			}
			yildiz+=1;
			PlayerPrefs.SetInt("yildiz",yildiz);
			Debug.Log(yildiz);
		}
	}
}
