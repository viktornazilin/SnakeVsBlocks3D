using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameLogic GameLogic;

    private void OnTriggerEnter(Collider other)
    {
        GameLogic.OnWin();
    }
}
