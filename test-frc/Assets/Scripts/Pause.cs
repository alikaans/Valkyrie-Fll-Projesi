using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	public GameObject helpcenter;
	public GameObject pause;
	public GameObject ipucu1;
	public GameObject ipucu2;
	//public GameObject devam;
	//public GameObject ayarlar;
	//public GameObject menu;
	
	void Start()
    {
        helpcenter.SetActive(false);
		pause.SetActive(false);
		ipucu1.SetActive(false);
		ipucu2.SetActive(false);
    }

	public void pauseon()
	{
		pause.SetActive(true);
		Time.timeScale = 0f;
	}
	
	public void pauseoff()
	{
		Time.timeScale = 1f;
		pause.SetActive(false);
	}
	
	public void helpcenteron()
	{
		helpcenter.SetActive(true);
		Time.timeScale = 0f;
	}
	
	public void helpcenteroff()
	{
		helpcenter.SetActive(false);
		Time.timeScale = 1f;
		ipucu1.SetActive(false);
		ipucu2.SetActive(false);
	}
	
	public void help1()
	{
		ipucu1.SetActive(true);
	}
	
	public void help2()
	{
		ipucu2.SetActive(true);
	}
	
}