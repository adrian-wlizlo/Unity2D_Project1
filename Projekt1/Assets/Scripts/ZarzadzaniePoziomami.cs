using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZarzadzaniePoziomami : MonoBehaviour
{
    public void LadujPoziom()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void NowaGra()
    {
        SceneManager.LoadScene("Scena1");
    }
    

    public void PrzeladujPoziom()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
