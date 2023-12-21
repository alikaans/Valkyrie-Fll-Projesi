using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    public int OtoDilDurum;
    public string Dil;
    public Button TurkceButton, IngilizceButton;
    public List<Text> Metinler;
	public Dropdown Diller;

    private void Awake()
    {
       OtoDilDurum = PlayerPrefs.GetInt("OtoDilDurum");
       Dil = PlayerPrefs.GetString("Dil");

    }
    void Start()
    { 
        if(OtoDilDurum == 0)
        {
            if(Application.systemLanguage == SystemLanguage.Turkish)
            {
                Dil = "Turkish";
                PlayerPrefs.SetString("Dil", Dil);
            }
            else if (Application.systemLanguage == SystemLanguage.English)
            {
                Dil = "English";
                PlayerPrefs.SetString("Dil", Dil);
            }
            else
            {
                Dil = "Turkish";
                PlayerPrefs.SetString("Dil", Dil);
            }

        }
        if (Dil == "Turkish")
        {
			//Dropdown dropdown = Diller.GetComponent<Dropdown>();
            //TurkceButton.interactable = false;
            //IngilizceButton.interactable = true;
			Diller.value = 0;
            Metinler[0].text = "Oyna";
            Metinler[1].text = "Ayarlar";
            Metinler[2].text = "Mağaza";
            Metinler[3].text = "Atölye";
            Metinler[4].text = "Çıkış";
			Metinler[5].text = "Ayarlar";
			Metinler[6].text = "Geri";
			Metinler[7].text = "Diller";
			Metinler[8].text = "Mağaza";
			Metinler[9].text = "Geri";
			Metinler[10].text = "Geri";
			Metinler[11].text = "Yetersiz Yıldız!";
        }

        else if (Dil == "English")
        {
			//Dropdown dropdown = Diller.GetComponent<Dropdown>();
			Diller.value = 1;
			//TurkceButton.interactable = true;
            //IngilizceButton.interactable = false;
            Metinler[0].text = "Play";
            Metinler[1].text = "Settings";
            Metinler[2].text = "Store";
            Metinler[3].text = "Workshop";
            Metinler[4].text = "Exit";
			Metinler[5].text = "Settings";
			Metinler[6].text = "Back";
			Metinler[7].text = "Languages";
			Metinler[8].text = "Store";
			Metinler[9].text = "Back";
			Metinler[10].text = "Back";
			Metinler[11].text = "Not Enough Stars!";
        }
    }
	
	public void HandleInputData(int val)
	{
		if(val==0)
		{
			Debug.Log("Türkçe");
			OtoDilDurum = 1;
			Dil = "Turkish";
			PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
			PlayerPrefs.SetString("Dil", Dil);
			Start();
		}
		if(val==1)
		{
			Debug.Log("İngilizce");
			OtoDilDurum = 1;
			Dil = "English";
			PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
			PlayerPrefs.SetString("Dil", Dil);
			Start();
		}
	}
	
    /*public void TurkceSec()
    {
        OtoDilDurum = 1;
        Dil = "Turkish";
        PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
        PlayerPrefs.SetString("Dil", Dil);
        Start();

    }
    public void IngilizceSec()
    {
        OtoDilDurum = 1;
        Dil = "English";
        PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
        PlayerPrefs.SetString("Dil", Dil);
        Start();
    }*/

}