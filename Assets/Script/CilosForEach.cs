using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilosForEach : MonoBehaviour
{
  int fuerza;
  int vida;
  int defensa;
  void Awake()
  {
    Debug.Log("Hola");
  }
  // Start is called before the first frame update
  void Start()
  {
    GoldMachine(2);
    ComboBreaker(16);
    LevelUp(3);
    SearchElement(10);
    GreaterThan(9);
  }

  public void GoldMachine(int coins)
  {
    int totalGold = 0;
    for (int i = 0; i < coins; i++)
    {
      totalGold += 10 * (i + 1);
      //totalGold = totalGold + (10 * (i + 1));
    }
    Debug.Log("GoldMachine: " + totalGold);
  }

  public void ComboBreaker(int hits)
  {
    int totalHits = 1;
    for (int i = 0; i < hits; i++)
    {
      totalHits += i + 1;
    }
    Debug.Log("Combo: " + totalHits);
  }

  public void LevelUp(int level)
  {
    float totalXP = 0;
    for (int i = 0; i < level; i++)
    {
      totalXP += Mathf.Pow(i + 1, i + 1);
    }
    Debug.Log("Exp: " + totalXP);
  }

  public void SearchElement(int element)
  {
    int timesFind = 0;
    int[] items = { 10, 1, 2, 3, 1, 2, 5, 4, 8, 6, 7, 9, 4, 1, 5, 6, 8, 7, 9, 5, 4, 3, 2, 5, 4, 8 };
    foreach (int item in items)
    {
      if (item == element)
      {
        timesFind++;
      }
    }

    Debug.Log("Elemento encontrado: " + timesFind + " veces");
  }

  public void GreaterThan(int element)
  {
    int timesFind = 0;
    int[] items = { 10, 1, 2, 3, 1, 2, 5, 4, 8, 6, 7, 9, 4, 1, 5, 6, 8, 7, 9, 5, 4, 3, 2, 5, 4, 8 };
    foreach (int item in items)
    {
      if (item > element)
      {
        timesFind++;
      }
    }

    Debug.Log("Elementos mayores: " + timesFind);
  }


}
