using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoScript : MonoBehaviour
{
  public GameObject triangulo;
  public void MoverDeLugar()
  {
    triangulo.transform.position = new Vector3(5, 0, 0);

    triangulo.transform.Rotate(new Vector3(0, 0, 25));

  }

}
