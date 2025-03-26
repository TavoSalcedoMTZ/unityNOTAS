using UnityEngine;

public class ChA : ClasePadre 
{

  /*  public override void FuncionPadre()
    {
        Debug.Log("Cha");
    }*/
    public void AddScore(int points)
    {
       // FuncionPadre();
        Singleton.instance.Score += points;
        Debug.Log(Singleton.instance.Score);
    }

    public override void FuncionPadre2()
    {
        Debug.Log("CHA");
    }
}
