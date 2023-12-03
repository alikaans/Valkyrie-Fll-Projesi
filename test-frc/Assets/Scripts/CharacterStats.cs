using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
	public int robot;
	public int yildizSayisi;
	public int acilanSeviyeler;
	
	public CharacterStats()
	{
		
	}
	
	public CharacterStats(int robot,int yildizSayisi,int acilanSeviyeler)
	{
		this.robot = robot;
		this.yildizSayisi = yildizSayisi;
		this.acilanSeviyeler = acilanSeviyeler;
	}
}
