using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
    public void skipTurn()
    {
        Debug.Log("Skip Turn...");
    }
}
