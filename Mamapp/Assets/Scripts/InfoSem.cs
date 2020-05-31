using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoSem : MonoBehaviour
{

    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosSem.php"; //
    //private string UrlPosition = "http://soymariaojeda.com/mamappdb/MostrarDatosSem.php";


    public Text TextoP1;



    private string rta;


    void Start()
    {
        obtenerInfoSem();
    }
    public void obtenerInfoSem()
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
