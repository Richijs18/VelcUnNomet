using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IzvelneScript : MonoBehaviour
{
    //Pārvieto vienu izvēlni
    public void uzIzvelni()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
