using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryIntro : MonoBehaviour
{
    public int wait_time = 26;
    public string sceneName;

    private void Start()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(sceneName);
    }
}
