using System;
using UnityEngine;
using UnityEngine.SceneManagement;
  


public class SCENECHANGER : MonoBehaviour
{
    public void changescene ()
    {
        SceneManager.LoadScene("Main");
   }   
}
