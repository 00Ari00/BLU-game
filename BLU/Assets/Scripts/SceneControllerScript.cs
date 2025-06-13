using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControllerScript : MonoBehaviour
{
    public static SceneControllerScript _instance;

    void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void ReturnToMainScene()
    {
        SceneManager.LoadSceneAsync(0); // scene 1 is main scene
    }
}
