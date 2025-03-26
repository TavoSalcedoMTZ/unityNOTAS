using UnityEngine;

public class Singleton : MonoBehaviour
{


    public static Singleton instance;
    [HideInInspector]
    public int Score;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(this);
            DontDestroyOnLoad(gameObject);
        }
    }
  

}
