using UnityEngine;
using UnityEngine.UI;

public class karakter : MonoBehaviour
{
    public float hareketHizi = 0.25f; // Hareket hızı
    private bool artisYapildi = false;
	private float hedefX = 0.25f;
	public float ziplamaHizi = 0.50f; // Zıplama hızı
	private bool zipladi = false;
	private Animator animator;
	
	private Rigidbody rb;


	void Start()
	{
		hedefX = transform.position.x + 0.25f; // X pozisyonunu 10 birim artırarak hedef belirle
		rb = GetComponent<Rigidbody>();
		animator = GetComponent<Animator>();
	}
    // Butona tıklandığında çağrılacak fonksiyon
    public void OnButtonClicked()
    {
        // ResimTakip koduna erişim
        ResimTakip resimTakip = GameObject.FindObjectOfType<ResimTakip>();
		ResimTakip2 resimTakip2 = GameObject.FindObjectOfType<ResimTakip2>();
		
        if (resimTakip != null)
        {
            int deger = resimTakip.deger;
            Debug.Log(deger);

            if (deger == 1)
            {
                // Eğer "deger" 1 ise, yapılacak işlem
                Debug.Log("Deger 1 ise yapilacak islem");
				artisYapildi = true;
            }
            else if (deger == 2)
            {
                // Eğer "deger" 2 ise, yapılacak işlem
                Debug.Log("Deger 2 ise yapilacak islem");
				zipladi = true;
            }
        }
        else
        {
            Debug.LogWarning("ResimTakip kodu bulunamadi.");
        }
    }
	void Update()
	{
         if (artisYapildi)
        {
            // X pozisyonunu belirli hızda artır
            float artisMiktari = hareketHizi * Time.deltaTime;
            transform.position = new Vector3(transform.position.x + artisMiktari, transform.position.y, transform.position.z);

            // Hedefe ulaşıldığını kontrol et
            if (transform.position.x >= hedefX)
            {
                transform.position = new Vector3(hedefX, transform.position.y, transform.position.z);
                artisYapildi = false; // Artış tamamlandı
            }
        }
		else if(zipladi)
		{
			animator.SetTrigger("Animation");
		}
    }
}
