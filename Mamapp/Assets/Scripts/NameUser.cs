using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameUser : MonoBehaviour
{
    //private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosUsuario.php"; //http://soymariaojeda.com/
    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/leer.php"; //
    //private string UrlPosition = "http://soymariaojeda.com/mamappdb/leer.php";

    public Text TextoNombre;

    private string nom;

    private string rta;

    void Start()
    {
        obtenerInfoN();
    }

    public void obtenerInfoN()
    {
        StartCoroutine(datosN());
    }

    public IEnumerator datosN()
    {

        string info = UrlPosition + "?id=" + PlayerPrefs.GetInt("idIngreso"); ;

        WWW resultInfo = new WWW(info);

        yield return resultInfo;


        print(resultInfo.text);
        rta = resultInfo.text.Trim();

        string[] datosArray = rta.Split(" "[0]);

        if (datosArray.Length == 3)
        {
            nom = (datosArray[0]);

            TextoNombre.GetComponent<Text>().text = nom;
        }





    }






}