using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoEsta : MonoBehaviour
{

    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosProm.php"; //
    //private string UrlPosition = "http://soymariaojeda.com/mamappdb/MostrarDatosProm.php";


    public Text TextoP1;
   


    private string dato;
    private string rta;


    void Start()
    {
        obtenerInfoProm();
    }
    public void obtenerInfoProm()
    {
        StartCoroutine(datosN());
    }

    public IEnumerator datosN()
    {

        string info = UrlPosition + "?IDuser=" + PlayerPrefs.GetInt("idIngreso");

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        print(resultInfo.text);
        rta = resultInfo.text.Trim();

        TextoP1.GetComponent<Text>().text = rta;
    }

    

   }
