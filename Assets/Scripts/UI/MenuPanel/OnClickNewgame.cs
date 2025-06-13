using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickNewgame : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(1);
        Debug.Log("OnClick : New game");
    }
}
