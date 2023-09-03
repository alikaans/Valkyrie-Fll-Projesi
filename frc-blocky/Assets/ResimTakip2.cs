using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResimTakip2 : MonoBehaviour
{
    public GameObject ileriResim;
    public GameObject ileri2Resim;
	public int deger; // Diğer script tarafından okunabilir
	
    private void OnTriggerEnter2D(Collider2D collision)
    {
		GameObject other = collision.gameObject;
        if (other.CompareTag("ileri"))
        {
            Debug.Log("Büyük resmin içine ileri taglı resim girdi.");
			deger = 3;
        }
        else if (other.CompareTag("ileri2"))
        {
			deger = 4;
            Debug.Log("Büyük resmin içine ileri2 taglı resim girdi.");
        }
    }
	
	private void OnTriggerExit2D(Collider2D collision)
	{
		GameObject other = collision.gameObject;
        if (other.CompareTag("ileri"))
        {
            Debug.Log("Büyük resmin içine ileri taglı resim çıktı.");
			int? deger = null;
        }
        else if (other.CompareTag("ileri2"))
        {
			int? deger = null;
            Debug.Log("Büyük resmin içine ileri2 taglı resim çıktı.");
        }
	}
}

