using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class BotonesMenu2 : MonoBehaviour
{
    [SerializeField] UnityEvent anEvent;
    
    private void OnMouseDown()
    {
        
        anEvent.Invoke();
        SceneManager.LoadScene("Juego2");
    }
    
    public void EventClick()
    {
        print("Which also triggered this method as a UnityEvent!");
    }
}
