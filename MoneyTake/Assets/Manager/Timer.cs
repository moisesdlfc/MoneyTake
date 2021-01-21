using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Libreria que nos permite recargar escenas

public class Timer : MonoBehaviour
{
    // Tiempo máximo
    public float maxTime = 60f;

    // Cuenta atrás
    private float countdown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        countdown = maxTime; // Asignamos el valor de maxTime a countdown
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime son los segundos que han pasado desde la última vez
        // que se renderizó un frame
        countdown -= Time.deltaTime;

        Debug.Log("Cuenta atras: " + countdown);

        // Si la cuenta atrás finaliza...
        if (countdown <= 0)
        {
            Debug.Log("El tiempo se ha acabado, has perdido...");

            // Reset
            Coin.coinsCount = 0;

            // Recarga la escena
            SceneManager.LoadScene("MainScene");
        }
    }
}
