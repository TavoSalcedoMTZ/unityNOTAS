using UnityEngine;

public delegate void eventStorage(); 
public class EventsMain : MonoBehaviour
{


    public event eventStorage eventShoot;


    public void funcShoot()
    {
        if (eventShoot != null)
        {
            eventShoot.Invoke();
        }
        Debug.Log("Evento comun");
    }
}
