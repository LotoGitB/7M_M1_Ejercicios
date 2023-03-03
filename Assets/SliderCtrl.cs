using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderCtrl : MonoBehaviour
{
  public GameObject spriteTriangle;
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void ChangePosition()
  {
    Debug.Log(gameObject.GetComponent<Slider>().value);
    spriteTriangle.transform.position = new Vector3(gameObject.GetComponent<Slider>().value, spriteTriangle.transform.position.y, spriteTriangle.transform.position.z);
  }
}
