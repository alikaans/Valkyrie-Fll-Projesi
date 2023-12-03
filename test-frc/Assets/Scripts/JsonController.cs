using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonController : MonoBehaviour
{
	CharacterStats kullanici = new CharacterStats();
    // Start is called before the first frame update
    void Start()
    {
        JsonYukle();
    }
	
	public void JsonKaydet()
	{
		string jsonString = JsonUtility.ToJson(kullanici);
		File.WriteAllText(Application.dataPath+"/Saves/kullaniciJson.json",jsonString);
	}
	
	public void JsonYukle()
	{
		string yol = Application.dataPath + "/Saves/kullaniciJson.json";
		if(File.Exists(yol))
		{
			string jsonOku = File.ReadAllText(yol);
			kullanici = JsonUtility.FromJson<CharacterStats>(jsonOku);
		}
		else
		{
			Debug.Log("Hata");
		}
	}
}
