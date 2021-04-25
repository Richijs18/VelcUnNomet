using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IzvelneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void uzIzvelni()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
