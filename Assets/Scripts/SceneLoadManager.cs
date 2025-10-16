using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoadManager
{
    public static void LoadScene(int index)
    {
      SceneManager.LoadScene(index);
    }
}