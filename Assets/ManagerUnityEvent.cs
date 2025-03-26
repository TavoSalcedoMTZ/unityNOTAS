using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class ManagerUnityEvent : MonoBehaviour
{

    public UnityEvent evento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        evento.AddListener(funcionparaevent);
        
            evento.Invoke();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void funcionparaevent()
    {
        Debug.Log("Arreglar");
    }
}
