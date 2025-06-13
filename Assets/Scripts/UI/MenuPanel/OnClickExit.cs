using UnityEngine;

public class OnClickExit : MonoBehaviour
{
    public void OnClick()
    {
        Application.Quit();
        Debug.Log("OnClick : Exit game");
    }
}
