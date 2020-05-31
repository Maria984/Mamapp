using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoEsta2 : MonoBehaviour
{

    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosProm.php"; //
    //private string UrlPosition = "http://soymariaojeda.com/mamappdb/MostrarDatosProm.php";


    
    public Text Mayor;


    private string dato;
    private string rta;


    public void obtenerInfoMayor()
    {
        StartCoroutine(datosM());
    }

    public IEnumerator datosM()
    {

        string info = UrlPosition + "?IDuser=" + PlayerPrefs.GetInt("idIngreso");

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        print(resultInfo.text);
        rta = resultInfo.text.Trim();


        string[] datosArray = rta.Split(","[0]);

        if (datosArray.Length >= 0)
        {
            dato = (datosArray[0]);

            Mayor.GetComponent<Text>().text = dato;
            //print(dato);

        }

    }

}
