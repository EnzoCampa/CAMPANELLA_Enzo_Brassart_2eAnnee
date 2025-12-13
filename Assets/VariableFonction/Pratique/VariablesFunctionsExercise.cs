using System;
using UnityEngine;

public class VariablesFunctionsExercise : MonoBehaviour
{
    int tata = 5;
    int toto = 7;

    int titi = 2;
    float tutu = 6.34f;

    int test = 65;

    int value;

    void Start()
    {
        Exo1PartieA();
        Exo1PartieB();
        Exo2();
        Add(10,8);
        Add(12f, 8.5f);
        Multiply(10, 20, ref value);
        Debug.Log($"Valeur de la multiplication : {value}");
        IsMajor(12);
    }

    void Exo1PartieA()
    {
        Debug.Log($"tata : {tata} toto : {toto}");
        (tata, toto) = (toto, tata);
        Debug.Log($"tata : {tata} toto : {toto}");
    }

    void Exo1PartieB()
    {
        Debug.Log($"tata : {tutu} toto : {titi}");
        (titi, tutu) = ((int)tutu, (float)titi);
        Debug.Log($"tata : {tutu} toto : {titi}");
    }

    void Exo2()
    {
        Debug.Log($"test : {(char)test}");
    }

    public int Add(int A, int B)
    { 
        Debug.Log($"fonction int add {A + B}");
        return A + B;
    }
    public float Add(float A, float B)
    {
        Debug.Log($"fonction float add {A + B}");
        return A + B;
    }

    void Multiply(int A, int B, ref int C)
    {
        C = A * B;
    }
    void IsMajor(int age)
    {
        Debug.Log($"Majeur ? {age >= 18}");
    }
}
