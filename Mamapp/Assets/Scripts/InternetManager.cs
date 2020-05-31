using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InternetManager : MonoBehaviour
{

    public Text checkInternet;
    private string urlData = "http://tadeolabhack.com:8081/test/Datos/mamappdb/isConection.php";
    //private string urlData = "http://soymariaojeda.com/mamappdb/isConection.php";


    // Start is called before the first frame update h
    void Start()
    {
        StartCoroutine(_checkInternet());
    }

    public IEnumerator _checkInternet()
    {
        WWW getData = new WWW(urlData);
        yield return getData;

        print(getData.text);

        if (getData.text == "ConexionEstablecida")
        {
            checkInternet.text = "Conectado a internet";
        }
        else
        {
            checkInternet.text = getData.error;
        }
    }
}
