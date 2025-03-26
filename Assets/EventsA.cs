using UnityEngine;
using UnityEngine.Rendering;

public class EventsA : MonoBehaviour
{

    public EventsMain main = new EventsMain();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        main.eventShoot += ShootA;
    }
    void Start()
    {
        main.funcShoot();
    }

 public void ShootA()
    {
        Debug.Log("Shoot A");
    }
}
