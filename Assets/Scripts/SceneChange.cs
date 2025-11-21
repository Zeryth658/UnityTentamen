using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
