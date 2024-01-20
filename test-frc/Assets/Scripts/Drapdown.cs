using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drapdown : MonoBehaviour
{
	int deger=0;
	public GameObject sensor;
	public GameObject gyro1;
	public GameObject ultra;
	public GameObject dokunma1;
	public GameObject isik1;
	
	void Start()
	{
		if(PlayerPrefs.GetInt("gyro")==1){
			gyro1.SetActive(true);
		}
		if(PlayerPrefs.GetInt("isik")==1){
			isik1.SetActive(true);
		}
		if(PlayerPrefs.GetInt("dokunma")==1){
			dokunma1.SetActive(true);
		}
		if(PlayerPrefs.GetInt("ultrasonik")==1){
			ultra.SetActive(true);
		}
	}
	
	public void HandleInputData(int val)
	{
		if(val==0)
		{
			sensor.SetActive(true);
			Debug.Log("0");
		}
		if(val==1)
		{
			sensor.SetActive(false);
			Debug.Log("1");
		}
		if(val==2)
		{
			sensor.SetActive(false);
			Debug.Log("2");
			
		}
	}
	
	public void gyro(){
		gyro1.SetActive(true);
		Debug.Log("Gyro takıldı");
		PlayerPrefs.SetInt("gyro",1);
	}
	

	public void ultrasonic(){
		ultra.SetActive(true);
		Debug.Log("Ultrasonik takıldı");
		PlayerPrefs.SetInt("ultrasonik",1);
	}


	public void dokunma(){
		dokunma1.SetActive(true);
		Debug.Log("Dokunma sensör takıldı");
		PlayerPrefs.SetInt("dokunma",1);
	}
	
	public void isik(){
		isik1.SetActive(true);
		Debug.Log("isik sensör takıldı");
		PlayerPrefs.SetInt("isik",1);
	}
	

}
