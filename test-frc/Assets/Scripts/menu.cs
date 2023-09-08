using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
	public GameObject menus;
	public GameObject seviyeler;
	public GameObject ayarlar;
	
	void Start()
    {
        seviyeler.SetActive(false);
		ayarlar.SetActive(false);
    }

	public void Level1(){
		SceneManager.LoadScene(1);
	}

	public void Level2(){
		SceneManager.LoadScene(2);
	}
	
	public void Seviyeler(){
		seviyeler.SetActive(true);
		menus.SetActive(false);
	}
	
	public void Geri(){
		seviyeler.SetActive(false);
		menus.SetActive(true);
		ayarlar.SetActive(false);
	}
	
	public void Ayarlar(){
		ayarlar.SetActive(true);
		menus.SetActive(false);
	}
	
	public void quitgame()
	{
		Debug.Log("çıktın");
		Application.Quit();
	}
}
