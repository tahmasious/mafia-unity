using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public void RedirectTo8Player()
    {
        SceneManager.LoadScene(0);
    }

    public void RedirectTo10Player ()
    {
        SceneManager.LoadScene(2);
    }

    public void RedirectTo12Player ()
    {
        SceneManager.LoadScene(3);
    }
}
