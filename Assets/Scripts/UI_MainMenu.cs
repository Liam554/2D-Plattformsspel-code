using UnityEngine;
using UnityEngine.SceneManagement;
public class UI_MainMenu : MonoBehaviour
{
    [SerializeField] private string sceneName = "SampleScene";

    public void PlayerGame()
    {
        SceneManager.LoadScene(sceneName);
    }

}
