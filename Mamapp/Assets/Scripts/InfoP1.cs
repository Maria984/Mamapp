using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoP1 : MonoBehaviour
{

    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosP1.php"; //
    //private string UrlPosition = "http://soymariaojeda.com/mamappdb/MostrarDatosP1.php";


    public Text TextoP1;

    

    private string rta;


    void Start()
    {
        obtenerInfoP1();
    }
    public void obtenerInfoP1()
    {
        StartCoroutine(datosN());
    }

    public IEnumerator datosN()
    {

        string info = UrlPosition;

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        print(resultInfo.text);
        rta = resultInfo.text.Trim();
              
        


        TextoP1.GetComponent<Text>().text = rta;





    }

}
