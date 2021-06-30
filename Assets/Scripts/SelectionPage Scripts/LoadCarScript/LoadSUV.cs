using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSUV : MonoBehaviour
{
    public IEnumerator PlayGame()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(2);   //Every time it's gonna load next scene
    }
    public void Nextscene()
    {

        StartCoroutine(PlayGame());
    }
    public void EndGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
