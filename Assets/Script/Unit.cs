using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

	public string unitName;
	public int unitLevel;

	public int damage;

	public int maxHP;
	public int currentHP;

	public bool TakeDamage(int dmg)
	{
	        //damage when final boss attack player
		currentHP -= dmg;

		if (currentHP <= 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	public void Heal(int amount)
	{
	        //terat in battle
		currentHP += amount;
		if (currentHP > maxHP)
			currentHP = maxHP;
	}

}
