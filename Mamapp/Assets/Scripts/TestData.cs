using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestData : MonoBehaviour
{
    private string getUrlEscribirTest = "http://tadeolabhack.com:8081/test/Datos/mamappdb/escribirTest.php"; //http://soymariaojeda.com/
    //private string getUrlEscribirTest = "http://soymariaojeda.com/mamappdb/escribirTest.php";

    private int idUsuario = 7;
    private string p1 = "";
    //private string p2 = "";
    //private string p3 = "";
    //private string p4 = "";
    //private int p5 = 0;
    private int p6 = 0;

    public InputField campoP1;
    //public InputField campoP2;
    //public InputField campoP3;
    //public InputField campoP4;
    //public InputField campoP5;
    public InputField campoP6;

    public Dropdown inter;
    public Dropdown inter2;
    public Dropdown inter3;
    public Dropdown inter4;

    private string drop;
    private string drop2;
    private string drop3;
    private string drop4;

    [SerializeField] private GameObject exitoso;
    [SerializeField] private GameObject mensaje;

   
    public void senTestData()
    {
        StartCoroutine(enviarDatosTest());
    }

    private IEnumerator enviarDatosTest()
    {

        if(inter.value == 0)
        {
            drop = "Sí";
        }
        else if(inter.value == 1)
        {
            drop = "No";
        }

        if (inter2.value == 0)
        {
            drop2 = "Ansiedad";
        }
        else if (inter2.value == 1)
        {
            drop2 = "Percepción física";
        }
        else if (inter2.value == 2)
        {
            drop2 = "Ambivalencia emocional";
        }
        else if (inter2.value == 3)
        {
            drop2 = "Cambios de humor";
        }
        else if (inter2.value == 4)
        {
            drop2 = "Odio";
        }
        else if (inter2.value == 5)
        {
            drop2 = "Estrés";
        }
        else if (inter2.value == 6)
        {
            drop2 = "Tocofobia";
        }
        else if (inter2.value == 7)
        {
            drop2 = "Trastorno de alimentación";
        }        
        else if (inter2.value == 8)
        {
            drop2 = "Tristeza";
        }
        else if (inter2.value == 9)
        {
            drop2 = "Discusiones";
        }
        else if (inter2.value == 10)
        {
            drop2 = "Ataques de pánico";
        }
        else if (inter2.value == 11)
        {
            drop2 = "Depresión";
        }


        if (inter3.value == 0)
        {
            drop3 = "Ansiedad";
        }
        else if (inter3.value == 1)
        {
            drop3 = "Percepción física";
        }
        else if (inter3.value == 2)
        {
            drop3 = "Ambivalencia emocional";
        }
        else if (inter3.value == 3)
        {
            drop3 = "Cambios de humor";
        }
        else if (inter3.value == 4)
        {
            drop3 = "Odio";
        }
        else if (inter3.value == 5)
        {
            drop3 = "Estrés";
        }
        else if (inter3.value == 6)
        {
            drop3 = "Tocofobia";
        }
        else if (inter3.value == 7)
        {
            drop3 = "Trastorno de alimentación";
        }
        else if (inter3.value == 8)
        {
            drop3 = "Tristeza";
        }
        else if (inter3.value == 9)
        {
            drop3 = "Discusiones";
        }
        else if (inter3.value == 10)
        {
            drop3 = "Ataques de pánico";
        }
        else if (inter3.value == 11)
        {
            drop3 = "Depresión";
        }

        if (inter4.value == 0)
        {
            drop4 = "1";
        }
        else if (inter4.value == 1)
        {
            drop4 = "2";
        }
        else if (inter4.value == 2)
        {
            drop4 = "3";
        }
        else if (inter4.value == 3)
        {
            drop4 = "4";
        }
        else if (inter4.value == 4)
        {
            drop4 = "5";
        }
        else if (inter4.value == 5)
        {
            drop4 = "6";
        }
        else if (inter4.value == 6)
        {
            drop4 = "7";
        }
        else if (inter4.value == 7)
        {
            drop4 = "8";
        }
        else if (inter4.value == 8)
        {
            drop4 = "9";
        }
        else if (inter4.value == 9)
        {
            drop4 = "10";
        }
        


        p1 = campoP1.text;
        //p2 = campoP2.text;
        //p3 = campoP3.text;
        //p4 = campoP4.text;

        if(campoP6.text != "")
        {
            //p5 = int.Parse(campoP5.text);
            p6 = int.Parse(campoP6.text);
        }
           
        //print(p1 + " " + p3 + " " + p4 + " " + p5 + " " + p6);

        if (p1 == "" || p6 == 0) // Los int == 0
        {
            mensaje.SetActive(true);// LLenar todos los campos
        }

        else
        {

            WWWForm formT = new WWWForm();
            formT.AddField("idUsuario_FK", PlayerPrefs.GetInt("idIngreso"));
            formT.AddField("pregunta1", p1); // Primero como le puse en el request [], luego como se llama en la variable arriba
            formT.AddField("pregunta2", drop);
            formT.AddField("pregunta3", drop2);
            formT.AddField("pregunta4", drop3);
            formT.AddField("pregunta5", drop4);
            formT.AddField("pregunta6", p6);

            WWW retroalimentacion = new WWW(getUrlEscribirTest, formT);
            yield return retroalimentacion;

            print(retroalimentacion.text);

            if (retroalimentacion.text == "Respuestas agregadas")
            {
                exitoso.SetActive(true);
            }
            else
            {
                exitoso.SetActive(true);
            }
        }



    }
}
