// NAMESPACE
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Libreria necesaria para usar TextMeshPro

//CLASS
public class Coin : MonoBehaviour
{
    // METODOS Y VARIABLES
    // Variable global y estática, una par todas las monedas.
    public static int coinsCount = 0;

    // Sonido moneda
    public AudioClip coinSound = null;

    // Contador total de monedas
    GameObject contadorTotal;

    // Contador monedas recogidas
    GameObject contadorRecogidas;

    private void Awake()
    {
        // Asignacion de contadorTotal
        contadorTotal = GameObject.Find("CoinsTotales");

        // Asignacion de contadorRecogidas
        contadorRecogidas = GameObject.Find("CoinsRecogidas");
    }

    // Start is called before the first frame update
    void Start()
    {
        Coin.coinsCount++; // Conteo de monedas
        Debug.Log("El juego ha comenzado y ahora hay " + Coin.coinsCount + " monedas.");

        // Actualiza el contador total de monedas
        contadorTotal.GetComponent<TextMeshProUGUI>().text = Coin.coinsCount.ToString();

        // Resetea contadorRecogidas
        contadorRecogidas.GetComponent<TextMeshProUGUI>().text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     * Método que se llama automaticamente
     * cuando otro collider entra en contacto
     * con el que tiene este script (la moneda).
     */
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            Coin.coinsCount--; // Coger moneda
            Debug.Log("Hemos recogido la moneda y ahora hay " + Coin.coinsCount + " monedas.");

            // Aumenta contadorRecogidas
            contadorRecogidas.GetComponent<TextMeshProUGUI>().text = (int.Parse(contadorRecogidas.GetComponent<TextMeshProUGUI>().text) + 1).ToString();

            //Reproduce coinSound en la posicion del jugador
            Vector3 playerPosition = GameObject.Find("FPSController").GetComponent<Transform>().position;
            AudioSource.PlayClipAtPoint(coinSound, playerPosition, 1.0f);

            // Si el jugador coge todas las monedas finaliza el juego.
            if (Coin.coinsCount == 0)
            {
                Debug.Log("Enhorabuena, has ganado.");

                // Disable time
                GameManager.DisableTime();

                // Activa los fireworks
                GameManager.ActiveFireworks();

                // Active el final text
                GameManager.SetActiveFinalText();
            }

            Destroy(gameObject); // Destruye la moneda
        }
    }
}