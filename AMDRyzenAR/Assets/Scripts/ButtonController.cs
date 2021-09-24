using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    //AR kamera button controller
    public void GoToArCamera()
    {
        SceneManager.LoadScene("ARCamera");
    }


    //Button Instruction
    public void GoToInstruction()
    {
        SceneManager.LoadScene("Instruction");
    }

    //Kembali ke Menu
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //Menuju Scene About
    public void GoToAbout()
    {
        SceneManager.LoadScene("About");
    }

    public void GoToAccessories1()
    {
        SceneManager.LoadScene("Accessories1");
    }

    public void GoToAccessories2()
    {
        SceneManager.LoadScene("Accessories2");
    }

    public void GoToBenchmark1()
    {
        SceneManager.LoadScene("Benchmark1");
    }

    public void GoToBenchmark2()
    {
        SceneManager.LoadScene("Benchmark2");
    }
}