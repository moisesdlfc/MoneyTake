using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Instanciación
        Person father = new Person("John", "Kramer", 73, true);
        Person mother = new Person("Marie", "Kramer", 68, false);
        Person son = new Person("Billy", "Saw", 8, true);

        Debug.Log(father.GetName() + " y " + mother.GetName() + " tienen un hijo llamado " + son.GetName());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
