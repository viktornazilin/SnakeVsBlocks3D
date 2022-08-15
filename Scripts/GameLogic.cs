using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public Controls Controls;
    private AudioSource background;
    public RestartUI RestartUI;
    public FinishUI FinishUI;
    public MainScreen MainScreen;
   public enum Status
    {
        Play,
        Lose,
        Win
    }
    public Status CurrentStatus { get; private set; }
    private void Start()
    {
        background = GetComponent<AudioSource>();
        background.Play();
    }
    public void OnDeath()
    {
        if (CurrentStatus != Status.Play) return;

        background.Stop();
        CurrentStatus = Status.Lose;
        Controls.Player.gameObject.SetActive(false);
        RestartUI.gameObject.SetActive(true);
        MainScreen.gameObject.SetActive(false);
    }
    public void OnWin()
    {
        if (CurrentStatus != Status.Play) return;

        background.Stop();
        CurrentStatus = Status.Win;
        Controls.Player.gameObject.SetActive(false);
        FinishUI.gameObject.SetActive(true);
        MainScreen.gameObject.SetActive(false);
    }
}
