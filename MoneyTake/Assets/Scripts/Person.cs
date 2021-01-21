using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PERSON ES UNA CLASE OBJETO, NO UN COMPORTAMIENTO POR LO QUE NO HEREDA MONOBEHAVIOUR
// LOS MONOBEHAVIOUR NO SE INSTANCIAN, SE AÑADEN COMO COMPONENTES
// MONOBEHAVIOUR ES PARA COMPORTAMIENTOS

public class Person
{
    // Encapsulamos la clase, para que solo ella pueda modificar variables
    private string firstName;
    private string lastName;
    private int age;
    private bool isMale;

    // Sobrecargamos el constructor
    public Person()
    {

    }

    public Person(string firstName, string lastName, int age, bool isMale)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.isMale = isMale;
    }

    // SETTERS Y GETTERS
    public void SetName(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string GetName()
    {
        string name = firstName + " " + lastName;
        return name;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return this.age;
    }

    public void SetIsMale(bool isMale)
    {
        this.isMale = isMale;
    }

    public bool GetIsMale()
    {
        return this.isMale;
    }
}
