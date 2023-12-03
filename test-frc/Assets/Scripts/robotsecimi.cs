using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class robotsecimi : MonoBehaviour
{
	public Toggle myToggle;
	public Toggle myToggle2;
	public Toggle myToggle3;
	public GameObject menu;
	public GameObject robots;
	public GameObject robots1;
	public GameObject robots2;
	public int robotskin;
	public GameObject yetersizYildiz;

	
	void Start()
    {
        myToggle2.isOn = false;
		myToggle3.isOn = false;
		robotskin = 1;
		PlayerPrefs.SetInt("robot",1);
    }

	public void ilkrobot(){
		myToggle.isOn = true;
		myToggle2.isOn = false;
		myToggle3.isOn = false;
		robotskin=1;
		Debug.Log(robotskin);
		robots.SetActive(true);
		robots1.SetActive(false);
		robots2.SetActive(false);
		PlayerPrefs.SetInt("robot",1);
		Debug.Log(PlayerPrefs.GetInt("robot"));
		
	}

	IEnumerator yildizsayisi () {
		yetersizYildiz.SetActive(true);
		Debug.Log("Yetersiz yıldız sayısı");
		yield return new WaitForSeconds (2);
		yetersizYildiz.SetActive(false);
	}
	
	public void ikirobot(){
		//StartCoroutine(yildizsayisi());
		myToggle.isOn = false;
		myToggle2.isOn = true;
		myToggle3.isOn = false;
		robotskin=2;
		Debug.Log(robotskin);
		robots.SetActive(false);
		robots1.SetActive(true);
		robots2.SetActive(false);
		PlayerPrefs.SetInt("robot",2);
		Debug.Log(PlayerPrefs.GetInt("robot"));
	}
	
	public void ucrobot(){
		//StartCoroutine(yildizsayisi());
		myToggle.isOn = false;
		myToggle2.isOn = false;
		myToggle3.isOn = true;
		robotskin=3;
		Debug.Log(robotskin);
		robots.SetActive(false);
		robots1.SetActive(false);
		robots2.SetActive(true);
		PlayerPrefs.SetInt("robot",3);
		Debug.Log(PlayerPrefs.GetInt("robot"));
	}
	
}