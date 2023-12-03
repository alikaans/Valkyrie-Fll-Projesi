//----------------------------------
// Version 1.0 (Sample)
//----------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The code implements a controller for a sequence of functions using the theory of machine language and
// its way to arrange functions to be run in a organized sequence. It run thought a list and base on the function list.
// The objective is to induce the player to use a Drag and Drop Visual programming interface to write its own code to
// interact with the game or parts of the game.
// This is a sample of a bigger project being developed with loops/conditions, functions with variables and a simple
// textual programming language enable the translation between Visual (blocks) and Textual coding.
// 
//#Visual Block Coding:
// drag and drop from (https://github.com/danielcmcg/Unity-UI-Nested-Drag-and-Drop) functinos to the desired positions
// on the main loop of the object

public class Controller : MonoBehaviour
{
	
    public delegate void FuntionsList();
    public GameObject mainTarget; //target object of the code is for
    List<Function_> sequence; //list of functions (type Functions_). The code sequence is read from here
    private int isPlaying; 
	public float rotationSpeed = 100.0f;
	public Material targetMaterial;
	public Material targetMaterialrenk;
	float siddeti;
	public GameObject ikibes;
	public GameObject bes;
	public GameObject yedibes;
	public GameObject yuz;
	public InputField inputField;
	int yildiz;
	public GameObject Kazandin;
	public Image resim;
    
    MainLoop loop1;
    
    public void Paly()
    {
        sequence.Clear();
        sequence = TranslateCodeFromBlocks(transform.parent, sequence);
        
        loop1 = new MainLoop(mainTarget, sequence);
        StartCoroutine(loop1.Play());

        isPlaying = 2; 
		
    }
	
	
    public void Stop()
    {
        isPlaying = 1; 
    }

    void Start()
    {
		PlayerPrefs.SetInt("gyroyon",0);
		PlayerPrefs.SetInt("move1",0);
		PlayerPrefs.SetInt("move2",0);
		PlayerPrefs.SetInt("ultrablock",0);
		PlayerPrefs.SetInt("ultrayon",0);
		PlayerPrefs.SetInt("siddetleri",0);
		
        isPlaying = 0; 
        sequence = new List<Function_>();
		
		//-------------Işık_Başlangıç------------//
        string[] elements = { "25", "50", "75", "100" };

        // Diziden rastgele bir eleman seç
        string randomElement = elements[Random.Range(0, elements.Length)];

        Debug.Log("Işık şiddeti: " + randomElement);

		if(randomElement=="25")
		{
			siddeti=0.25f;
		}
		if(randomElement=="50")
		{
			siddeti=0.50f;
		}
		if(randomElement=="75")
		{
			siddeti=0.75f;
		}
		if(randomElement=="100")
		{
			siddeti=1f;
		}
		
		Color currentColor = targetMaterial.color;
		currentColor.r = siddeti; // 0-1 arası
		targetMaterial.color = currentColor;
		
		if (int.TryParse(randomElement, out int parsedValue))
        {
            PlayerPrefs.SetInt("isik", parsedValue);
            Debug.Log("Rastgele Sayı PlayerPrefs'e Kaydedildi: " + parsedValue);
        }
		//-------------Işık_Son------------//
		
		//-------------Renk_Başlangıç------------//
        string[] elementler = { "1", "2",};//1 kırmızı,2 sarı

        // Diziden rastgele bir eleman seç
        string randomElementler = elementler[Random.Range(0, elementler.Length)];

        Debug.Log("renk: " + randomElementler);
		
		if(randomElementler=="1")
		{
			Color yeniRenk = new Color(1.0f, 0.0f, 0.0f); // kırmızı
			targetMaterialrenk.color = yeniRenk;
			PlayerPrefs.SetInt("rengi", 0); //kırmızı 0
		}
		if(randomElementler=="2")
		{
			Color yeniRenk = new Color(0.0f, 0.0f, 1.0f); // mavi
			targetMaterialrenk.color = yeniRenk;
			PlayerPrefs.SetInt("rengi", 1); //mavi 1
		}
		
 
    }
    
    void Update()
    {
		float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
		yildiz = PlayerPrefs.GetInt("yildiz");
		
        if (isPlaying == 2) //play
        {
            loop1.infiniteLoop = transform.GetChild(1).GetComponent<Toggle>().isOn;
            if (loop1.infiniteLoop && loop1.end)
            {
                StartCoroutine(loop1.Play());
            }
        }
        if (isPlaying == 1) //stop
        {
            StopCoroutine(loop1.Play());
        }
		
		if(PlayerPrefs.GetInt("siddetleri")==25)
		{
			ikibes.SetActive(true);
		}
		
		if(PlayerPrefs.GetInt("siddetleri")==50)
		{
			bes.SetActive(true);
		}
		
		if(PlayerPrefs.GetInt("siddetleri")==75)
		{
			yedibes.SetActive(true);
		}
		
		if(PlayerPrefs.GetInt("siddetleri")==100)
		{
			yuz.SetActive(true);
		}
    }
	
	public void tamam(){
		int inputValue = int.Parse(inputField.text);
        Debug.Log("InputField Değeri: " + inputValue);
		if(inputValue==PlayerPrefs.GetInt("siddetleri"))
		{
			Debug.Log("kazandın");
			resim.color = Color.yellow;
			Kazandin.SetActive(true);
			Time.timeScale = 0f;
			yildiz+=1;
			PlayerPrefs.SetInt("yildiz",yildiz);
			Debug.Log(yildiz);
		}
	}
	
	public void HandleInputData(int val)
	{
		if(val==0)
		{
			Debug.Log("1 block ilerle");
		}
		if(val==1)
		{
			Debug.Log("2 block ilerle");
		}
		if(val==2)
		{
			Debug.Log("3 block ilerle");
		}
		PlayerPrefs.SetInt("move1",val);
		Debug.Log(PlayerPrefs.GetInt("move1"));
	}
	
	public void HandleInputData1(int val)
	{
		if(val==0)
		{
			Debug.Log("1 block ilerle2");
		}
		if(val==1)
		{
			Debug.Log("2 block ilerle2");
		}
		if(val==2)
		{
			Debug.Log("3 block ilerle");
		}
		PlayerPrefs.SetInt("move2",val);
		Debug.Log(PlayerPrefs.GetInt("move2"));
	}
	
	public void HandleInputDataUltrasonicBlock(int val)
	{
		if(val==0)
		{
			Debug.Log("0 block");
		}
		if(val==1)
		{
			Debug.Log("1 block");
		}
		PlayerPrefs.SetInt("ultrablock",val);
		Debug.Log(PlayerPrefs.GetInt("ultrablock"));
	}
	
	public void HandleInputDataUltrasonicYon(int val)
	{
		if(val==0)
		{
			Debug.Log("sol");
		}
		if(val==1)
		{
			Debug.Log("sağ");
		}
		PlayerPrefs.SetInt("ultrayon",val);
		Debug.Log(PlayerPrefs.GetInt("ultrayon"));
	}
	
	public void HandleInputDataDokunYon(int val)
	{
		if(val==0)
		{
			Debug.Log("sol");
		}
		if(val==1)
		{
			Debug.Log("sağ");
		}
		PlayerPrefs.SetInt("dokunyon",val);
		Debug.Log(PlayerPrefs.GetInt("dokunyon"));
	}
	
	public void HandleInputDataRenkSec(int val)
	{
		if(val==0)
		{
			Debug.Log("Kırmızı");
		}
		if(val==1)
		{
			Debug.Log("Mavi");
		}
		PlayerPrefs.SetInt("renksecimi",val);
		Debug.Log(PlayerPrefs.GetInt("renksecimi"));
	}
	
	public void HandleInputDataRenkYon(int val)
	{
		if(val==0)
		{
			Debug.Log("sol");
		}
		if(val==1)
		{
			Debug.Log("sağ");
		}
		PlayerPrefs.SetInt("renkyon",val);
		Debug.Log(PlayerPrefs.GetInt("renkyon"));
	}
    
    //recursive parser function
    private List<Function_> TranslateCodeFromBlocks(Transform parent, List<Function_> sequence_)
    {
        foreach (Transform child in parent)
        {
            var functionName = child.name.Split('_'); //looks like a little face ^^

            if (functionName[0] == "Function")
            {
                string function = functionName[1];
                switch (function)
                {
					case "Move1":
                        sequence_.Add(new Move1("Move1"));
						if(PlayerPrefs.GetInt("move1")==1){
							sequence_.Add(new Move1("Move1"));
						}
						if(PlayerPrefs.GetInt("move1")==2){
							sequence_.Add(new Move1("Move1"));
							sequence_.Add(new Move1("Move1"));
						}
						if(PlayerPrefs.GetInt("move1")==3){
							sequence_.Add(new Move1("Move1"));
							sequence_.Add(new Move1("Move1"));
							sequence_.Add(new Move1("Move1"));
						}
						//PlayerPrefs.SetInt("gitti",0);
                        break;
					case "Move2":
                        sequence_.Add(new Move2("Move2"));
						if(PlayerPrefs.GetInt("move2")==1){
							sequence_.Add(new Move2("Move2"));
							Debug.Log("2İlerleniyor..");
						}
						if(PlayerPrefs.GetInt("move2")==2){
							sequence_.Add(new Move2("Move2"));
							sequence_.Add(new Move2("Move2"));
							Debug.Log("3İlerleniyor..");
						}
						if(PlayerPrefs.GetInt("move2")==3){
							sequence_.Add(new Move2("Move2"));
							sequence_.Add(new Move2("Move2"));
							sequence_.Add(new Move2("Move2"));
						}
                        break;
                    case "Spin":
                        sequence_.Add(new Spin("Spin"));
                        break;
					case "ultra":
                        sequence_.Add(new ultra("ultra"));
                        break;
					case "dokunma":
                        sequence_.Add(new dokunma("dokunma"));
                        break;
					case "IsikSiddeti":
                        sequence_.Add(new IsikSiddeti("IsikSiddeti"));
                        break;
					case "Renk":
                        sequence_.Add(new Renk("Renk"));
                        break;
                }
            }
        }
        
        return sequence_;
    }
    
}

public class MainLoop
{
    GameObject mainTarget;
    List<Function_> sequence_;
    public bool infiniteLoop;
    public bool end;
    private float waitTime;

    public MainLoop(GameObject mainTarget, List<Function_> sequence_)
    {
        this.end = false;
        this.mainTarget = mainTarget;
        this.sequence_ = sequence_;
        this.waitTime = 1.2f; //wait time between functions in sequence (list)
    }
    public IEnumerator Play()
    {
        WaitForSeconds wait = new WaitForSeconds(waitTime);
        this.end = false;
        foreach (Function_ fun in this.sequence_)
        {
            fun.Func(this.mainTarget);
            yield return wait;
        }
        this.end = true;
    }
    
}

public class Spin : Function_
{
    public Spin(string ID) : base(ID)
    {
        this.ID = ID;
    }

    override public void Func(GameObject mainTarget)
    {
		
		Debug.Log(PlayerPrefs.GetInt("gyro"));
		if(PlayerPrefs.GetInt("gyro")==1)
		{
			Debug.Log("gyro takılı");
			if(PlayerPrefs.GetInt("gyroyon")==0)
			{
				mainTarget.transform.Rotate(0, 90, 0);
			}
			if(PlayerPrefs.GetInt("gyroyon")==1)
			{
				mainTarget.transform.Rotate(0, -90, 0);
			}
			// Küpü 90 derece döndürme
			//mainTarget.transform.Rotate(0, 90, 0);
		}
		else
		{
			Debug.Log("Gyro Takılı Değil");
		}
    }
}

public class ultra : Function_
{
    public ultra(string ID) : base(ID)
    {
        this.ID = ID;
    }

    override public void Func(GameObject mainTarget)
    {
		
		Debug.Log(PlayerPrefs.GetInt("ultrasonik"));
		if(PlayerPrefs.GetInt("ultrasonik")==1)
		{
			Debug.Log("ultrasonik takılı");
			if(PlayerPrefs.GetInt("ultrakarsi")==1)
			{
				if(PlayerPrefs.GetInt("ultrayon")==0)
				{
					mainTarget.transform.Rotate(0,-90, 0);
				}
				if(PlayerPrefs.GetInt("ultrayon")==1)
				{
					mainTarget.transform.Rotate(0,90, 0);
				}
			}
			// Küpü 90 derece döndürme
			//mainTarget.transform.Rotate(0, 90, 0);
		}
		else
		{
			Debug.Log("ultrasonik Takılı Değil");
		}
    }
}

public class IsikSiddeti : Function_
{
	
    public IsikSiddeti(string ID) : base(ID)
    {
        this.ID = ID;
    }

    override public void Func(GameObject mainTarget)
    {
			
		Debug.Log(PlayerPrefs.GetInt("isik"));
		if(1==1)
		{
			Debug.Log("ışık sensörü takılı");
			if(PlayerPrefs.GetInt("isik")==0)
			{
				Debug.Log("HATA");
			}
			if(PlayerPrefs.GetInt("isik")==25)
			{
				Debug.Log("25de");
				//ikibes.SetActive(true);
				PlayerPrefs.SetInt("siddetleri",25);
			}
			if(PlayerPrefs.GetInt("isik")==50)
			{
				Debug.Log("50de");
				//bes.SetActive(true);
				PlayerPrefs.SetInt("siddetleri",50);
			}
			if(PlayerPrefs.GetInt("isik")==75)
			{
				Debug.Log("75de");
				//yedibes.SetActive(true);
				PlayerPrefs.SetInt("siddetleri",75);
			}
			if(PlayerPrefs.GetInt("isik")==100)
			{
				Debug.Log("100de");
				//yuz.SetActive(true);
				PlayerPrefs.SetInt("siddetleri",100);
			}
		}
		else
		{
			Debug.Log("ışık sensörü Takılı Değil");
		}
    }
}

public class Renk : Function_
{
	
    public Renk(string ID) : base(ID)
    {
        this.ID = ID;
    }

    override public void Func(GameObject mainTarget)
    {
			
		Debug.Log(PlayerPrefs.GetInt("renk"));
		if(1==1)
		{
			Debug.Log("renk sensörü takılı");
			if(PlayerPrefs.GetInt("rengi")==PlayerPrefs.GetInt("renksecimi"))
			{
				Debug.Log("tuttu");
				if(PlayerPrefs.GetInt("renkyon")==0)
				{
					//sol
					mainTarget.transform.Rotate(0,-90, 0);
				}
				if(PlayerPrefs.GetInt("renkyon")==1)
				{
					//sağ
					mainTarget.transform.Rotate(0,90, 0);
				}
			}
			else
			{
				Debug.Log("YANLIŞ RENK");
			}
		}
		else
		{
			Debug.Log("renk sensörü Takılı Değil");
		}
    }
}

public class dokunma : Function_
{
    public dokunma(string ID) : base(ID)
    {
        this.ID = ID;
    }

    override public void Func(GameObject mainTarget)
    {
		
		Debug.Log(PlayerPrefs.GetInt("dokun"));
		if(PlayerPrefs.GetInt("dokunma")==1)
		{
			Debug.Log("dokunma takılı");
			if(PlayerPrefs.GetInt("dokundu")==1)
			{
				if(PlayerPrefs.GetInt("dokunyon")==0)
				{
					mainTarget.transform.Rotate(0,-90, 0);
				}
				if(PlayerPrefs.GetInt("dokunyon")==1)
				{
					mainTarget.transform.Rotate(0,90, 0);
				}
			}
			// Küpü 90 derece döndürme
			//mainTarget.transform.Rotate(0, 90, 0);
		}
		else
		{
			Debug.Log("dokunma sensörü Takılı Değil");
		}
    }
}

	
public class Move1 : Function_
{
    public Move1(string ID) : base(ID)
    {
        this.ID = ID;
		Debug.Log(ID);
    }

    override public void Func(GameObject mainTarget)
    {
		
		int kac = PlayerPrefs.GetInt("move1");
		/*if(kac == 0 /*&& PlayerPrefs.GetInt("gitti") != 1)
		{
			Vector3 moveDirection = mainTarget.transform.forward;
			float moveSpeed = 6.0f; // Hareket hızını ayarlayabilirsiniz
			mainTarget.GetComponent<Rigidbody>().velocity = moveDirection * moveSpeed;
			Debug.Log("Nesnenin Yönü: " + mainTarget.transform.forward);
			//PlayerPrefs.SetInt("gitti",1);
		}*/
		Debug.Log("İlerleniyor..");
		Vector3 moveDirection = mainTarget.transform.forward;
		float moveSpeed = 6.0f; // Hareket hızını ayarlayabilirsiniz
		mainTarget.GetComponent<Rigidbody>().velocity = moveDirection * moveSpeed;
		Debug.Log("Nesnenin Yönü: " + mainTarget.transform.forward);
		Debug.Log(mainTarget.gameObject.tag);
    }
}

public class Move2 : Function_
{
    public Move2(string ID) : base(ID)
    {
        this.ID = ID;
		Debug.Log(ID);
    }

    override public void Func(GameObject mainTarget)
    {
		
		int kac = PlayerPrefs.GetInt("move2");
		/*if(kac == 0 && PlayerPrefs.GetInt("gitti") != 1)
		{
			Vector3 moveDirection = mainTarget.transform.forward;
			float moveSpeed = 6.0f; // Hareket hızını ayarlayabilirsiniz
			mainTarget.GetComponent<Rigidbody>().velocity = moveDirection * moveSpeed;
			Debug.Log("Nesnenin Yönü: " + mainTarget.transform.forward);
			//PlayerPrefs.SetInt("gitti",1);
		}*/
		Vector3 moveDirection = mainTarget.transform.forward;
		float moveSpeed = 6.0f; // Hareket hızını ayarlayabilirsiniz
		mainTarget.GetComponent<Rigidbody>().velocity = moveDirection * moveSpeed;
		Debug.Log("Nesnenin Yönü: " + mainTarget.transform.forward);
		Debug.Log(mainTarget.gameObject.tag);
    }
	
}



public class Function_
{
    public string ID;

    //contructor for sinple functions
    public Function_(string ID)
    {
        this.ID = ID;
    }

    public virtual void Func(GameObject mainTarget)
    {

    }

}