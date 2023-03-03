using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RuletaCtrl : MonoBehaviour
{
  public TextMeshProUGUI puntosFinales;
  public TextMeshProUGUI apuestaColor;
  private float speed;
  private float limit = 5;
  private float timeStop;
  private bool colorRed = true;
  private int puntosObtenidos = 0;
  // Start is called before the first frame update
  void Start()
  {
    timeStop = Time.time - limit;
    CambiarApuesta();
  }

  // Update is called once per frame
  void Update()
  {
    if ((timeStop + limit) > Time.time)
    {
      gameObject.transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
  }

  public void SpinTheWheel()
  {
    timeStop = Time.time;
    speed = Random.Range(100f, 1000f);
  }

  public void CambiarApuesta()
  {

    colorRed = !colorRed;

    if (colorRed)
    {
      apuestaColor.text = "Rojo";
    }
    else
    {
      apuestaColor.text = "Azul";
    }
  }

  public void VerificarRespuesta()
  {
    Debug.Log(gameObject.transform.rotation.eulerAngles.z);
    if (gameObject.transform.rotation.z < 0 && !colorRed)
    {
      //Es lado azul
      Debug.Log("Azul");
      puntosObtenidos++;
      puntosFinales.text = "Puntos: " + puntosObtenidos;
    }
    else if (gameObject.transform.rotation.z > 0 && colorRed)
    {
      //Es lado Rojo
      Debug.Log("Rojo");
      puntosObtenidos++;
      puntosFinales.text = "Puntos: " + puntosObtenidos;
    }
  }
}
