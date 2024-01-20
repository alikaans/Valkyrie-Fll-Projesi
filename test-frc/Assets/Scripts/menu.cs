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
	public GameObject INFO, Amac1, Amac7, Amac9, Amac8;
	public GameObject Gereken1, Gereken234, Gereken6, Gereken79, Gereken8;
	public GameObject Yapilacak1, Yapilacak24, Yapilacak3, Yapilacak6, Yapilacak79, Yapilacak8;
	int leveL;
	
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
		INFO.SetActive(false);
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
	
	public void GerInfo(){
		INFO.SetActive(false);
		Amac1.SetActive(false);
		Amac7.SetActive(false);
		Amac8.SetActive(false);
		Amac9.SetActive(false);
		Gereken1.SetActive(false);
		Gereken234.SetActive(false);
		Gereken6.SetActive(false);
		Gereken79.SetActive(false);
		Gereken8.SetActive(false);
		Yapilacak1.SetActive(false);
		Yapilacak24.SetActive(false);
		Yapilacak3.SetActive(false);
		Yapilacak6.SetActive(false);
		Yapilacak79.SetActive(false);
		Yapilacak8.SetActive(false);
	}
	
	public void InfOyna()
	{
		leveL = PlayerPrefs.GetInt("level");
		SceneManager.LoadScene(leveL);
	}

	public void Level1(){
		INFO.SetActive(true);
		Amac1.SetActive(true);
		Gereken1.SetActive(true);
		Yapilacak1.SetActive(true);
		//SceneManager.LoadScene(1);
		PlayerPrefs.SetInt("level",1);
	}

	public void Level2(){
		INFO.SetActive(true);
		Amac1.SetActive(true);
		Gereken234.SetActive(true);
		Yapilacak24.SetActive(true);
		//SceneManager.LoadScene(2);
		PlayerPrefs.SetInt("level",2);
	}

	public void Level3(){
		Amac1.SetActive(true);
		Gereken234.SetActive(true);
		Yapilacak3.SetActive(true);
		INFO.SetActive(true);
		//SceneManager.LoadScene(3);
		PlayerPrefs.SetInt("level",3);
	}

	public void Level4(){
		Amac1.SetActive(true);
		Gereken234.SetActive(true);
		Yapilacak24.SetActive(true);
		INFO.SetActive(true);
		//SceneManager.LoadScene(4);
		PlayerPrefs.SetInt("level",4);
	}
	
	public void Level5(){
	}

	public void Level6(){
		Amac1.SetActive(true);
		Gereken6.SetActive(true);
		Yapilacak6.SetActive(true);
		INFO.SetActive(true);
		//SceneManager.LoadScene(6);
		PlayerPrefs.SetInt("level",6);
	}
	
	public void Level7(){
		Amac7.SetActive(true);
		Gereken79.SetActive(true);
		Yapilacak79.SetActive(true);
		INFO.SetActive(true);
		//SceneManager.LoadScene(7);
		PlayerPrefs.SetInt("level",7);
	}

	public void Level8(){
		Amac8.SetActive(true);
		Gereken8.SetActive(true);
		Yapilacak8.SetActive(true);
		INFO.SetActive(true);
		//SceneManager.LoadScene(8);
		PlayerPrefs.SetInt("level",8);
	}
	
	public void Level9(){
		Amac9.SetActive(true);
		Gereken79.SetActive(true);
		Yapilacak79.SetActive(true);
		INFO.SetActive(true);
		//SceneManager.LoadScene(9);
		PlayerPrefs.SetInt("level",9);
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
		INFO.SetActive(false);
		Amac1.SetActive(false);
		Amac7.SetActive(false);
		Amac8.SetActive(false);
		Amac9.SetActive(false);
		Gereken1.SetActive(false);
		Gereken234.SetActive(false);
		Gereken6.SetActive(false);
		Gereken79.SetActive(false);
		Gereken8.SetActive(false);
		Yapilacak1.SetActive(false);
		Yapilacak24.SetActive(false);
		Yapilacak3.SetActive(false);
		Yapilacak6.SetActive(false);
		Yapilacak79.SetActive(false);
		Yapilacak8.SetActive(false);
        seviyeler.SetActive(false);
		map.SetActive(false);
		ayarlar.SetActive(false);
		tema2.SetActive(false);
		magaza.SetActive(false);
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
