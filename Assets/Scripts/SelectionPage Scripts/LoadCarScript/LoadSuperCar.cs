using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSuperCar : MonoBehaviour
{
   
   public IEnumerator PlayGame()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(3);
    }

    public void nextScene()
    {
        StartCoroutine(PlayGame());
    }

    public void EndGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
