using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongTransform : MonoBehaviour
{
  public float speed;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (gameObject.transform.position.x < 7)
    {
      gameObject.transform.position = new Vector3(gameObject.transform.position.x + (1 * Time.deltaTime * speed), -3, 0);
    }
    else
    {
      gameObject.transform.position = new Vector3(-6, -3, 0);
    }
  }
}
