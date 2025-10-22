using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamestarter : MonoBehaviour
{
    public void changescene()
    {
        SceneManager.LoadScene("platform");
    }
}
