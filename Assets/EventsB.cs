using UnityEngine;

public class EventsB : MonoBehaviour
{
    public EventsMain main = new EventsMain();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        main.eventShoot += ShootB;
    }
    void Start()
    {

    }

    public void ShootB()
    {
        Debug.Log("Shoot b");
    }
}