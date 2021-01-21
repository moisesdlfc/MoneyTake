using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour
{

    /*
     * VARIABLES
     */
    public int myNumber = 13; // Creación y asignación
    public int code; // Creación

    // TIPOS DE DATOS BÁSICOS
    bool booleanVariable; // true o false
    int integerNumber; // ... -5 -3 -1 0 1 3 5 ...
    float floatNumber; // ... -32.87654287 0.09847567 5.98742487
    double doubleNumber; // ... -32.8765428787654287 0.0984756709847567 5.9874248798742487
    char characterVariable; // 'a'
    string text; // "example text"

    // Todas las estructuras de datos empiezan en 0.
    // El ultimo elemento de una estructura de datos es el de su dimensión - 1.

    // ARRAYS
    // - Es homogeneo (solo un tipo de dato)
    // - Es de tamaño fijo
    // - Tiene un orden
    public string[] students = new string[] { "Cintia", "Moises", "Sombra", "Nala" };
    public string[] studentsWithoutAssignment = new string[4];


    // LISTAS
    // - Es homogeneo (solo un tipo de dato)
    // - Es de tamaño dinámico
    // - Tiene un orden
    public List<string> alumnos = new List<string>();


    // ARRAYLIST
    // - Es heterogeneo (diferentes tipos de datos)
    // - Es de tamaño dinámico
    // - Tiene un orden
    public ArrayList inventory = new ArrayList();


    // DICCIONARIO O HASHTABLE
    // - Es heterogeneo (diferentes tipos de datos)
    // - Es de tamaño dinámico
    // - No tiene un orden, tiene una clave
    public Hashtable personalDetails = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        code = myNumber - 3; // Asignación

        if (EnterTheParty(27, 12))
        {
            Debug.Log("Puedes entrar a la fiesta");
        } else
        {
            Debug.Log("No puedes entrar a la fiesta");
        }

        // Add -> Añade elementos al final de una lista
        alumnos.Add("Cintia");
        alumnos.Add("Moises");

        // Remove -> Elimina elementos de una lista
        if (alumnos.Contains("Moises"))
        {
            alumnos.Remove("Moises");
        }

        // ToArray() -> Convierte una lista en un array
        string[] alumnosToArray = alumnos.ToArray();

        // Clear -> Eliminar definitivamente todos los elementos de la lista
        alumnos.Clear();

        // .Length para saber tamaño de array
        Debug.Log("Hay " + students.Length + " students (array)");

        // .Count para saber tamaño de lista
        Debug.Log("Hay " + alumnos.Count + " alumnos (lista)");

        // Add to Arraylist
        inventory.Add(3);
        inventory.Add(13.3432);
        inventory.Add("Texto de prueba");
        inventory.Add(true);
        inventory.Add(GameObject.FindGameObjectsWithTag("Fireworks"));

        // Add to Hashtable
        personalDetails.Add("firstName", "Gaara");
        personalDetails.Add("lastName", "del Desierto");
        personalDetails.Add("age", 16);
        personalDetails.Add("hasChildren", false);

        // Por seguridad, no se pueden hacer estas cosas:
        //string nombre = personalDetails["firstName"];
        // No se sabe que tipo de dato se va a devolver
        // Para ello tenemos que hacer un cast, para decirle explicitamente
        // que tipo de dato es, bajo nuestra responsabilidad de errar
        string nombre = (string)personalDetails["firstName"];

        // BUCLE FOREACH
        // foreach (tipoDato variable in coleccion)
        int[] notasAlumno = new int[] {3, 0, 5, 7, 8, 9, 10, 10};

        int suma = 0;
        int cantidad = notasAlumno.Length;

        foreach (int nota in notasAlumno)
        {
            suma = suma + nota;
        }

        Debug.Log("La media aritmetica del alumno es " + (suma/cantidad));

        // BUCLE FOR
        // for (inicializacion, condicion, iterador)
        for (int i = 10; i >= 0; i--)
        {
            Debug.Log("i: " + i);
        }

        // BUCLE WHILE
        // while (condicion)
        // Es obligatorio hacer antes la inicializacion y durante el bucle la iteración
        int vueltas = 0;
        while (vueltas < 10)
        {
            vueltas++;
        }
        Debug.Log("Ya he dado " + vueltas + " vueltas");

        // EJERCICIO PAR E IMPAR
        for (int i = 0; i < 100; i++)
        {
            if (i == 0)
            {
                Debug.Log("El número 0 es especial...");
            } else if (IsNumberEven(i))
            {
                Debug.Log("El número " + i + " es par");
            } else
            {
                Debug.Log("El número " + i + " es impar");
            }
        }

        // NUMERO PRIMO
        int valor = 43;
        bool isPrime = true;

        for (int i = 2; i < valor; i++)
        {
            if (valor % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Debug.Log("El número " + valor + " es primo");
        } else
        {
            Debug.Log("El número " + valor + " es compuesto");
        }

        // ALGORITMO DE BÚSQUEDAS
        int objectPos = -1;

        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Equals("Moises"))
            {
                objectPos = i;
                break;
            }
        }

        if (objectPos == -1)
        {
            Debug.Log("El objeto no se ha encontrado...");
        } else
        {
            Debug.Log("El objeto esta en la posicion " + objectPos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Time.time nos da el tiempo que ha pasado desde que ha arrancado el juego
        Debug.Log("Llevas jugando " + Time.time + " segundos");

        if (Input.GetKeyDown(KeyCode.Return))
        {
            AddTwoNumbers();
        }
    }

    // FixedUpdate hace un Update en un rango de tiempo fijo, por ende se ejecuta menos veces
    // por segundo que el Update. Se suele usar para cosas relacionadas con la física. (Ej: gravedad)
    private void FixedUpdate()
    {
        
    }

    void AddTwoNumbers()
    {
        Debug.Log(myNumber + code);
    }

    bool EnterTheParty(int age, int money)
    {
        if (age >= 18 && money >=25)
        {
            return true;
        } else
        {
            return false;
        }
    }

    bool IsNumberEven(int number)
    {
        int remainder = number % 2;

        if (remainder == 0)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
