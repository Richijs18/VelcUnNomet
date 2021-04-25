using System.Collections;
using UnityEngine;
//Importē, lai varētu ielādēt ainas
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    //Izdarot klikšķi uz pogas "Retry", tiks atvērta aina "Galvena Izvelne"
    public void izvelesMaina()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}