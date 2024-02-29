using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yildizlar : MonoBehaviour
{
	public Text yildizSayisi;
	int sayilar;

    public void ChangeText(string sayi)
    {
        yildizSayisi.text = sayi;
    }
	
	void Update()
	{
		sayilar = PlayerPrefs.GetInt("yildiz");
		string strsayilar = sayilar.ToString();
		ChangeText(strsayilar);
	}
}
