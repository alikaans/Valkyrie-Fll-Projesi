using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
	public GameObject menus;
	public GameObject seviyeler;
	public GameObject tema2;
	public GameObject ayarlar;
	public GameObject atolye;
	public GameObject magaza;
	public GameObject yetersizYildiz;
	public GameObject map;
	
	void Start()
    {
        seviyeler.SetActive(false);
		map.SetActive(false);
		ayarlar.SetActive(false);
		atolye.SetActive(false);
		tema2.SetActive(false);
		magaza.SetActive(false);
		menus.SetActive(true);
		yetersizYildiz.SetActive(false);
		Debug.Log(SceneManager.GetActiveScene().name);
    }
	
	public void HEPSINISIL(){
		PlayerPrefs.DeleteAll();
		Debug.Log("Hepsi Silindi");
		Debug.Log(PlayerPrefs.GetInt("yildiz"));
		Debug.Log(PlayerPrefs.GetInt("ultrasonik"));
		Debug.Log(PlayerPrefs.GetInt("gyro"));
		Debug.Log(PlayerPrefs.GetInt("robot"));
		Debug.Log(PlayerPrefs.GetInt("renk"));
		Debug.Log(PlayerPrefs.GetInt("isik"));
		Debug.Log(PlayerPrefs.GetInt("dokunma"));
	}

	public void Level1(){
		SceneManager.LoadScene(1);
	}

	public void Level2(){
		SceneManager.LoadScene(2);
	}

	public void Level3(){
		SceneManager.LoadScene(3);
	}

	public void Level4(){
		SceneManager.LoadScene(4);
	}
	
	public void Level5(){
		SceneManager.LoadScene(5);
	}

	public void Level6(){
		SceneManager.LoadScene(6);
	}
	
	public void Level7(){
		SceneManager.LoadScene(7);
	}

	public void Level8(){
		SceneManager.LoadScene(8);
	}
	
	public void Level9(){
		SceneManager.LoadScene(9);
	}

	public void Level10(){
		SceneManager.LoadScene(10);
	}
	
	public void Seviyeler(){
		seviyeler.SetActive(true);
		menus.SetActive(false);
		tema2.SetActive(false);
		map.SetActive(true);
	}
	
	public void Magaza(){
		menus.SetActive(false);
		magaza.SetActive(true);
	}

	public void Atolye(){
		menus.SetActive(false);
		atolye.SetActive(true);
	}

	IEnumerator Tema2yildiz () {
		yetersizYildiz.SetActive(true);
		yield return new WaitForSeconds (2);
		yetersizYildiz.SetActive(false);
	}
	
	public void Tema2(){
		//StartCoroutine(Tema2yildiz());
		tema2.SetActive(true);
		//seviyeler.SetActive(false);
	}
	
	public void Geri(){
		seviyeler.SetActive(false);
		menus.SetActive(true);
		ayarlar.SetActive(false);
		magaza.SetActive(false);
		tema2.SetActive(false);
		atolye.SetActive(false);
		map.SetActive(false);
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
