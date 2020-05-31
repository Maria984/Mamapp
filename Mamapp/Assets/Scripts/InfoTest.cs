using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class InfoTest : MonoBehaviour
{
    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosProm.php";
    //private string UrlPosition = "http://soymariaojeda.com/mamappdb/MostrarDatosProm.php";

    public Text TextoTest;

    private string valor;
    private string rta;

    public void obtenerInfo()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
        string info = UrlPosition + "?IDuser=" + PlayerPrefs.GetInt("idIngreso");

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        rta = resultInfo.text.Trim(); //Borrar los espacios que hay
        print(rta);

        //print(resultInfo.text);

        /*string[] datosArray = rta.Split(","[0]);

        if (datosArray.Length == 6)
        {
            valor = (datosArray[1]);
            print(valor);
            TextoTest.GetComponent<Text>().text = valor;
        }
        */




    }






}