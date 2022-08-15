using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public int NextScene { get; private set; }
    private void Awake()
    {
        NextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }
    public void Play()
    {
        if (NextScene < SceneManager.sceneCountInBuildSettings) SceneManager.LoadScene(NextScene);            
        else SceneManager.LoadScene(1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(NextScene - 1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
