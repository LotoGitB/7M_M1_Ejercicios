using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PruebaTriangulo : MonoBehaviour
{
  public Slider slider;
  public void MoverDeLugar()
  {
    gameObject.transform.position = new Vector3(5, 0, 0);
  }

  public void CambioSlider()
  {
    Debug.Log("Fire");
    Debug.Log(slider.value);
    gameObject.transform.position = new Vector3(slider.value, 0, 0);
  }
}
