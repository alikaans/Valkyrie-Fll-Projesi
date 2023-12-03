using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drapdown : MonoBehaviour
{
	int deger=0;
	public GameObject sensor;
	public GameObject teker;
	public GameObject aa;
	public GameObject bosluk1;
	public GameObject bosluk2;
	public GameObject bosluk3;
	public GameObject gyro;
	public GameObject tekerfoto1;
	public GameObject aafoto1;
	
	void Start()
	{
		if(PlayerPrefs.GetInt("gyro")==1){
			bosluk2.SetActive(false);
			gyro.SetActive(true);
		}
		if(PlayerPrefs.GetInt("ultrasonik")==1){
			bosluk1.SetActive(false);
			tekerfoto1.SetActive(true);
		}
		if(PlayerPrefs.GetInt("dokunma")==1){
			bosluk3.SetActive(false);
			aafoto1.SetActive(true);
		}
	}
	
	public void HandleInputData(int val)
	{
		if(val==0)
		{
			sensor.SetActive(true);
			teker.SetActive(false);
			aa.SetActive(false);
			Debug.Log("0");
		}
		if(val==1)
		{
			sensor.SetActive(false);
			teker.SetActive(true);
			aa.SetActive(false);
			Debug.Log("1");
		}
		if(val==2)
		{
			sensor.SetActive(false);
			teker.SetActive(false);
			aa.SetActive(true);
			Debug.Log("2");
			
		}
	}
	
	public void butonmotor1(){
		bosluk2.SetActive(false);
		gyro.SetActive(true);
		Debug.Log("Gyro takıldı");
		PlayerPrefs.SetInt("gyro",1);
	}
	

	public void butonteker1(){
		bosluk1.SetActive(false);
		tekerfoto1.SetActive(true);
		Debug.Log("Ultrasonik takıldı");
		PlayerPrefs.SetInt("ultrasonik",1);
	}


	public void butonaa1(){
		bosluk3.SetActive(false);
		aafoto1.SetActive(true);
		Debug.Log("Dokunma sensör takıldı");
		PlayerPrefs.SetInt("dokunma",1);
	}
	

}
