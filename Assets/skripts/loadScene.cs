using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadScene : MonoBehaviour
{
    public void loadOnePLayer()
    {
        SceneManager.LoadScene("pong1player");
    }

    public void loadTwoPLayer()
    {
        SceneManager.LoadScene("pong2player");
    }

    public void loadHardMode()
    {
        SceneManager.LoadScene("hardmode");
    }
}
