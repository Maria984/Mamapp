﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IngresoUser : MonoBehaviour
{
    private string UrlIngreso = "http://tadeolabhack.com:8081/test/Datos/mamappdb/leerIngreso.php"; 
    //private string UrlIngreso = "http://soymariaojeda.com/mamappdb/leerIngreso.php";


    private int idInPhp;

    private string correo = "";

    public Text mensaje;

    private string rta;

    public InputField campoCorreo;

    [SerializeField] private GameObject exitoso;

    void Start()
    {
        
    }

    public void Ingreso()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {

        correo = campoCorreo.text;

        WWWForm formIU = new WWWForm();

        formIU.AddField("cor", correo); //Primero como en el php, la accion que quiero, después el nombre

        WWW retroalimentacion = new WWW(UrlIngreso, formIU);
        yield return retroalimentacion;

        //print(retroalimentacion.text);
        rta = retroalimentacion.text.Trim(); //Borrar los espacios que hay
        print(rta);

        if (rta == "Error")
        {            
            mensaje.text = "Datos Incorrectos";
        }

        else
        {
            string[] datosArray = rta.Split(char.Parse(","));

            if (datosArray.Length == 2)
            {
                idInPhp = int.Parse(datosArray[1]);
                PlayerPrefs.SetInt("idIngreso", idInPhp);
                exitoso.SetActive(true);                
            }
        }

  
    }

    








}