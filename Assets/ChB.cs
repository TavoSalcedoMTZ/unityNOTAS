using UnityEngine;

public class ChB : ClasePadre
{ 
    public void RestScore(int points)
    {

       // FuncionPadre();
        Singleton.instance.Score -= points;
        Debug.Log(Singleton.instance.Score);
    }
    public override void FuncionPadre2()
    {
        Debug.Log("CHB");
    }
}

