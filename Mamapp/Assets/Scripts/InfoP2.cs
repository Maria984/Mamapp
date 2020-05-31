using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoP2 : MonoBehaviour
{

    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/MostrarDatosP2.php"; //
                                                                                                        //private string UrlPosition = "http://soymariaojeda.com/mamappdb/MostrarDatosP2.php";


    public Text TextoSi;
    public Text TextoNo;
    public Text TextoSuma;


    private string rta;
    private string rta2;

    private int rtaInt;
    private int rta2Int;

    private int sumita;

    public void obtenerInfoN()
    {
        StartCoroutine(datosN());
    }

    public IEnumerator datosN()
    {

        string info = UrlPosition + "?resP2=" + "Si" ;
        string info2 = UrlPosition + "?resP2=" + "No";


        WWW resultInfo = new WWW(info);
        WWW resultInfo2 = new WWW(info2);

        yield return resultInfo;
        yield return resultInfo2;


        print(resultInfo.text);
        print(resultInfo2.text);

        rta = resultInfo.text.Trim();
        rta2 = resultInfo2.text.Trim();

        TextoSi.GetComponent<Text>().text = "Si: " + rta + " usuarias";
        TextoNo.GetComponent<Text>().text = "No: " + rta2 + " usuarias";

        rtaInt = int.Parse(rta);
        rta2Int = int.Parse(rta2);

        sumita = (rtaInt + rta2Int);

        TextoSuma.GetComponent<Text>().text = "Total de respuestas: " + sumita;

    }





}
