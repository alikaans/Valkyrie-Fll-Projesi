/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonSave : MonoBehaviour
{
	public void Json_Kaydet(Kisi kisi)
	{
		string kisiJsonFormatli = JsonUtility.ToJson(kisi);
		System.IO.File.WriteAllText(Application.persistentdataPath+"/Saves/kullaniciJson.json", kisiJsonFormatli);
	}
	
	public Kisi Json_Oku()
	{
		String JsonVeri = System.IO.File.WriteAllText(Application.persistentdataPath+"/Saves/kullaniciJson.json");
		Kisi OkunanKisi = JsonUtility.FromJson<Kisi>(JsonVeri);
		
		return OkunanKisi;
	}
}
*/