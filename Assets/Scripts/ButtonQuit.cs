using UnityEngine;

public class ButtonQuit : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("ButtonQuit.OnMouseDown");
        Application.Quit();
    }
}