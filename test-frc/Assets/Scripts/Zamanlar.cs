using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Zamanlar : MonoBehaviour
{
	float zaman=0f;
	public Image resim;
	public Text zamantext;
	string sahne;
	public GameObject Kazandin;
	int bitti=0;

    void Start()
    {
		sahne = SceneManager.GetActiveScene().name;
        resim.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
		zaman += Time.deltaTime;
		zamantext.text="Zaman : "+(int)zaman;
		
		if(sahne == "level1")
		{
			if (Kazandin.activeSelf)
			{
			
				if (zaman > 10f)
				{
					// Zaman 30 saniyeden uzunsa resmi kırmızı yap
					resim.color = Color.red;
				}
				else
				{
					// Zaman 30 saniyeden kısa ise resmi sarı yap
					resim.color = Color.yellow;
					bitti+=1;
					yildizlar();
				}	
			}
		}
		else if(sahne == "level2")
		{
			if (zaman > 25f)
			{
				// Zaman 30 saniyeden uzunsa resmi kırmızı yap
				resim.color = Color.red;
			}
			else
			{
				// Zaman 30 saniyeden kısa ise resmi sarı yap
				resim.color = Color.yellow;
			}
		}

        }
	
	public void yildizlar()
	{
		if(bitti==1)
		{
			int yildiz = PlayerPrefs.GetInt("yildiz");
			yildiz+=1;
			PlayerPrefs.SetInt("yildiz",yildiz);
		}
	}
}
