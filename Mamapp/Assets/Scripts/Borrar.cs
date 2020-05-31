using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Borrar : MonoBehaviour
{
    //private string UrlBorrar = "http://soymariaojeda.com/mamappdb/BorrarTest.php"; //http://tadeolabhack.com:8081/test/Datos/
    private string UrlBorrar = "http://tadeolabhack.com:8081/test/Datos/mamappdb/BorrarTest.php";
    private string UrlUpdate = "http://tadeolabhack.com:8081/test/Datos/mamappdb/BorrarUsuario.php";

    

    private string nombreU = "";
    private string correoU = "";
    private string contrasenaU = "";
    public InputField campoNombre;
    public InputField campoCorreo;
    public InputField campoContrasena;

    [SerializeField] private GameObject exitoso;
    [SerializeField] private GameObject exitosoCambio;


    public void borrarUsuario()
    {
        StartCoroutine(borrarU());
    }
    private IEnumerator borrarU()
    {
        WWWForm formBU = new WWWForm();

        formBU.AddField("in", "BorrarUsuario"); //Primero como en el php, la accion que quiero, después el nombre
        formBU.AddField("userID", PlayerPrefs.GetInt("idIngreso")); //Como le puse al campo del id arriba

        WWW retroalimentacion = new WWW(UrlBorrar, formBU);
        yield return retroalimentacion;

        print(retroalimentacion.text);
    }



    public void borrarDatosUsuario()
    {
        StartCoroutine(borrarDU());
    }
    private IEnumerator borrarDU()
    {
        WWWForm formDU = new WWWForm();

        formDU.AddField("in", "BorrarDatosTest");
        formDU.AddField("userID", PlayerPrefs.GetInt("idIngreso"));

        WWW retroalimentacion = new WWW(UrlBorrar, formDU);
        yield return retroalimentacion;

        print(retroalimentacion.text);
        exitoso.SetActive(true);
    }


    public void editarUsuario()
    {
        StartCoroutine(editarU());
    }
    private IEnumerator editarU()
    {
        nombreU = campoNombre.text;
        correoU = campoCorreo.text;
        contrasenaU = campoContrasena.text;

        if (nombreU != "" && correoU == "" && contrasenaU == "") //Solo nombre
        {
            WWWForm formEU = new WWWForm();
            formEU.AddField("in", "EditarUsuarioNombre");
            formEU.AddField("userID", PlayerPrefs.GetInt("idIngreso"));
            formEU.AddField("nNombre", nombreU);

            WWW retroalimentacion = new WWW(UrlUpdate, formEU);
            yield return retroalimentacion;

            print(retroalimentacion.text);
            exitosoCambio.SetActive(true);
        }
        if (nombreU != "" && correoU != "" && contrasenaU == "") //Nombre y correo
        {
            WWWForm formEU = new WWWForm();
            formEU.AddField("in", "EditarUsuarioNombreCorreo");
            formEU.AddField("userID", PlayerPrefs.GetInt("idIngreso"));
            formEU.AddField("nNombre", nombreU);
            formEU.AddField("nCorreo", correoU);

            WWW retroalimentacion = new WWW(UrlUpdate, formEU);
            yield return retroalimentacion;

            print(retroalimentacion.text);
            exitosoCambio.SetActive(true);
        }
        if (nombreU != "" && correoU != "" && contrasenaU != "") //Los 3
        {
            WWWForm formEU = new WWWForm();
            formEU.AddField("in", "EditarUsuarioNombreCorreoContrasena");
            formEU.AddField("userID", PlayerPrefs.GetInt("idIngreso"));
            formEU.AddField("nNombre", nombreU);
            formEU.AddField("nCorreo", correoU);
            formEU.AddField("nContrasena", contrasenaU);

            WWW retroalimentacion = new WWW(UrlUpdate, formEU);
            yield return retroalimentacion;

            print(retroalimentacion.text);
            exitosoCambio.SetActive(true);
        }
        if(nombreU == "" && correoU != "" && contrasenaU == "") //Solo correo
        {
            WWWForm formEU = new WWWForm();
            formEU.AddField("in", "EditarUsuarioCorreo");
            formEU.AddField("userID", PlayerPrefs.GetInt("idIngreso"));
            formEU.AddField("nCorreo", correoU);

            WWW retroalimentacion = new WWW(UrlUpdate, formEU);
            yield return retroalimentacion;

            print(retroalimentacion.text);
            exitosoCambio.SetActive(true);
        }

        if (nombreU == "" && correoU == "" && contrasenaU != "") //Solo contraseña
        {
            WWWForm formEU = new WWWForm();
            formEU.AddField("in", "EditarUsuarioContrasena");
            formEU.AddField("userID", PlayerPrefs.GetInt("idIngreso"));
            formEU.AddField("nContrasena", contrasenaU);

            WWW retroalimentacion = new WWW(UrlUpdate, formEU);
            yield return retroalimentacion;

            print(retroalimentacion.text);
            exitosoCambio.SetActive(true);
        }
        if (nombreU != "" && correoU == "" && contrasenaU != "") //Nombre y contrasena
        {
            WWWForm formEU = new WWWForm();
            formEU.AddField("in", "EditarUsuarioNombreContrasena");
            formEU.AddField("userID", PlayerPrefs.GetInt("idIngreso"));
            formEU.AddField("nNombre", nombreU);
            formEU.AddField("nContrasena", contrasenaU);

            WWW retroalimentacion = new WWW(UrlUpdate, formEU);
            yield return retroalimentacion;

            print(retroalimentacion.text);
            exitosoCambio.SetActive(true);
        }
        if (nombreU == "" && correoU != "" && contrasenaU != "") //Correo y contrasena
        {
            WWWForm formEU = new WWWForm();
            formEU.AddField("in", "EditarUsuarioCorreoContrasena");
            formEU.AddField("userID", PlayerPrefs.GetInt("idIngreso"));
            formEU.AddField("nCorreo", correoU);
            formEU.AddField("nContrasena", contrasenaU);

            WWW retroalimentacion = new WWW(UrlUpdate, formEU);
            yield return retroalimentacion;

            print(retroalimentacion.text);
            exitosoCambio.SetActive(true);
        }


        



        


    }

}
