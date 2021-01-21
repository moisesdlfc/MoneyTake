using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Creación de variable para el timer
    private static Timer timer;

    // Creación de variable para texto mision cumplida
    private static GameObject misionCompletada;

    // Creacion de array para almacenar los fireworks
    private static GameObject[] fireworksSystem;

    // Start is called before the first frame update
    void Start()
    {
        // Referencia timer
        timer = GameObject.Find("GameManager").GetComponent<Timer>();

        // Referencia MisionCumplida
        misionCompletada = GameObject.Find("MisionCompletada");
        //Deshabilita misionCumplida
        misionCompletada.SetActive(false);

        // Referencia los fireworks de la escena
        fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");
    }

    // Update is called once per frame
    void Update()
    {
        // Si el usuario pulsa la tecla Escape, se cierra el juego
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.LogAssertion("Saliendo del juego...");
            Application.Quit();
        }
    }

    // Activa el texto final
    public static void SetActiveFinalText()
    {
        misionCompletada.SetActive(true);
    }

    // Desactiva el timer
    public static void DisableTime()
    {
        timer.enabled = false;
    }

    // Activa los fireworks
    public static void ActiveFireworks()
    {
        // Recorremos todos los fireworks
        foreach (GameObject firework in fireworksSystem)
        {
            // Play fireworks
            firework.GetComponent<ParticleSystem>().Play();
            firework.GetComponent<AudioSource>().Play();
        }
    }
}
