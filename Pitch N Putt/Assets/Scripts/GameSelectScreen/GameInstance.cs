using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameInstance : MonoBehaviour
{


    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnBtnClicked);
    }


    void OnBtnClicked()
    {
        GameScenes.Instance.ChangeSceneTo(GameScenes.Scenes.TestGame);
    }
}


