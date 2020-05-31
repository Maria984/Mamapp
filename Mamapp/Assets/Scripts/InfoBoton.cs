using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class InfoBoton : MonoBehaviour
{
    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/mamappdb/leerBoton.php";
    //private string UrlPosition = "http://soymariaojeda.com/mamappdb/leerBoton.php";

    public Text TextoUno;
    public Text TextoDos;
    public Text TextoTres;
    public Text TextoCuatro;
    public Text TextoCinco;
    public Text TextoSeis;
    public Text TextoSiete;
    public Text TextoOcho;
    public Text TextoNueve;
    public Text TextoDiez;
    public Text TextoOnce;
    public Text TextoDoce;

    private int uno;
    private int dos;
    private int tres;
    private int cuatro;
    private int cinco;
    private int seis;
    private int siete;
    private int ocho;
    private int nueve;
    private int diez;
    private int once;
    private int doce;

    private string unoS;
    private string dosS;
    private string tresS;
    private string cuatroS;
    private string cincoS;
    private string seisS;
    private string sieteS;
    private string ochoS;
    private string nueveS;
    private string diezS;
    private string onceS;
    private string doceS;

    private string rta;

    public void obtenerInfoB()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
        string info = UrlPosition + "?id=" + "4";

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        rta = resultInfo.text.Trim(); //Borrar los espacios que hay
        print(rta);

        string[] datosArray = rta.Split(char.Parse(","));

        if (datosArray.Length == 12)
        {
            uno = int.Parse(datosArray[0]);
            dos = int.Parse(datosArray[1]);
            tres = int.Parse(datosArray[2]);
            cuatro = int.Parse(datosArray[3]);
            cinco = int.Parse(datosArray[4]);
            seis = int.Parse(datosArray[5]);
            siete = int.Parse(datosArray[6]);
            ocho = int.Parse(datosArray[7]);
            nueve = int.Parse(datosArray[8]);
            diez = int.Parse(datosArray[9]);
            once = int.Parse(datosArray[10]);
            doce = int.Parse(datosArray[11]);

             

            unoS = uno.ToString();
            dosS = dos.ToString();
            tresS = tres.ToString();
            cuatroS = cuatro.ToString();
            cincoS = cinco.ToString();
            seisS = seis.ToString();
            sieteS = siete.ToString();
            ochoS = ocho.ToString();
            nueveS = nueve.ToString();
            diezS = diez.ToString();
            onceS = once.ToString();
            doceS = doce.ToString();

            TextoUno.GetComponent<Text>().text = unoS;
            TextoDos.GetComponent<Text>().text = dosS;
            TextoTres.GetComponent<Text>().text = tresS;
            TextoCuatro.GetComponent<Text>().text = cuatroS;
            TextoCinco.GetComponent<Text>().text = cincoS;
            TextoSeis.GetComponent<Text>().text = seisS;
            TextoSiete.GetComponent<Text>().text = sieteS;
            TextoOcho.GetComponent<Text>().text = ochoS;
            TextoNueve.GetComponent<Text>().text = nueveS;
            TextoDiez.GetComponent<Text>().text = diezS;
            TextoOnce.GetComponent<Text>().text = onceS;
            TextoDoce.GetComponent<Text>().text = doceS;

            
        }

        



    }
}