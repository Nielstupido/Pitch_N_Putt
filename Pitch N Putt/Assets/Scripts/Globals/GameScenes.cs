using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameScenes : MonoBehaviour
{
    public static GameScenes Instance { get; private set; }
    public enum Scenes
    {
        GameSelect,
        TestGame
    };


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
    }


    public void ChangeSceneTo(Scenes sceneIndex)
    {
        if ((int)sceneIndex == SceneManager.GetActiveScene().buildIndex)
        {
            return;
        }
        
        SceneManager.LoadScene((int)sceneIndex);
    }
}
