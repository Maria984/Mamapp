using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ocultar4 : MonoBehaviour
{
    
    [SerializeField] private GameObject ocultar2;
    [SerializeField] private GameObject ocultar3;

    [SerializeField] private GameObject btn1;
    [SerializeField] private GameObject btn2;
    [SerializeField] private GameObject btn3;

    [SerializeField] private GameObject img4;
    [SerializeField] private GameObject img5;

    public GameObject textLinea;
    public GameObject textTitulo;

    public float borrar = 1;

    public GameObject bebe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (borrar >= 0)
        {
            textLinea.GetComponent<Text>().text = "Tiempo";
            textTitulo.GetComponent<Text>().text = "Mueve la línea " + "\r\n" + "de tiempo";
            textTitulo.GetComponent<Text>().fontSize = 74;            
            ocultar2.SetActive(false);
            ocultar3.SetActive(false);
            //bebe.gameObject.GetComponent<Animator>().enabled = false;
        }
        if (borrar >= 1)
        {
            textLinea.GetComponent<Text>().text = "10 Semanas";
            textTitulo.GetComponent<Text>().text = "Tristeza";
            textTitulo.GetComponent<Text>().fontSize = 125;
            ocultar2.SetActive(true);
            btn1.SetActive(true);
            btn2.SetActive(false);
            btn3.SetActive(false);
            ocultar3.SetActive(false);
            //bebe.gameObject.GetComponent<Animator>().enabled = true;
        }
        if (borrar >= 2)
        {
            textLinea.GetComponent<Text>().text = "20 Semanas";
            textTitulo.GetComponent<Text>().text = "Discusiones";
            textTitulo.GetComponent<Text>().fontSize = 125;
            ocultar2.SetActive(true);
            btn1.SetActive(false);
            btn2.SetActive(true);
            btn3.SetActive(false);
            ocultar3.SetActive(false);
        }
        if (borrar >= 3)
        {
            textLinea.GetComponent<Text>().text = "28 Semanas";
            textTitulo.GetComponent<Text>().text = "Ataques de pánico";
            textTitulo.GetComponent<Text>().fontSize = 125;
            ocultar2.SetActive(true);
            btn1.SetActive(false);
            btn2.SetActive(false);
            btn3.SetActive(true);
            ocultar3.SetActive(false);
        }
        if (borrar >= 4)
        {
            textLinea.GetComponent<Text>().text = "Fin";
            textTitulo.GetComponent<Text>().text = "¿Qué deseas hacer?";
            textTitulo.GetComponent<Text>().fontSize = 74;
            ocultar2.SetActive(false);
            ocultar3.SetActive(true);
        }
        
    }

    public void ToggleAnalog(float newBorrar)
    {
        borrar = newBorrar;
    }
}
