using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicloDos : MonoBehaviour
{
  //public int[] cajas = { 1,2,3,4,5 };
  //public Vector3[] posiciones = new[] { new Vector3(1, 5, 0), new Vector3(-5, -5, 0), new Vector3(5, -5, 0) };
  //public int enemyHP = 10;
  public string[] cajas = { "Juan", "Alf", "Serch", "Karly", "Joy" };
  // Start is called before the first frame update
  void Start()
  {
    // for (int i = 0; i < 5; i++)
    // {
    //   Debug.Log(i);
    // }

    // int j = 0;
    // while (j < 5)
    // {
    //   Debug.Log(j);
    //   j++;
    //   //j = j + 1;
    // }

    foreach (string c in cajas)
    {
      Debug.Log(c);
    }


    //enemyHP = Dodamage(enemyHP, 6);
    //Debug.Log(enemyHP);
    //enemyHP = Dodamage(enemyHP, 3);
    //Debug.Log(enemyHP);

    // Debug.Log(cajas[0]);
    // Debug.Log(cajas[4]);
    // Debug.Log(cajas[cajas.Length - 1]);
    // Debug.Log(cajas[Random.Range(0, cajas.Length)]);

    //gameObject.transform.position = new Vector3(1, 5, 0);
    
    //gameObject.transform.position = posiciones[Random.Range(0, posiciones.Length)];

  }

  // Start is called before the first frame update   

  int Dodamage(int enemy, int damage)
  {
    enemy = enemy - damage;
    return enemy;
  }
  // Update is called once per frame
  int Restore()
  {
    return 10;
  }
}
