using UnityEngine;

public class ConditionsLoopsExercise : MonoBehaviour
{
    [SerializeField]
    private int _starTriangleSize = 2;
    [SerializeField]
    private int _userAge = 2;
    [SerializeField]
    private int _factorialValue = 2;

    int[] Table = new int[] { 84, 6, 41, 157, 64, 29, 1, 42 };

    private void Start()
    {
        CheckUserAge();
        DrawTriangle();
        PrintFactorial();
        BubbleSort();
    }

    public void CheckUserAge()
    {

        if (_userAge < 18)
        {
            Debug.Log("mineur");
        }
        else if (_userAge >= 18)
        {
            Debug.Log("majeur");
        }
        else if (_userAge >= 64)
        {
            Debug.Log("retriate");
        }
    }
    public void DrawTriangle()
    {
        string triangle = "";

        for (int i = 0; i <= _starTriangleSize; i++)
        {
            triangle += new string('*', i) + "\n";
        }

        Debug.Log(triangle);
    }


    public void PrintFactorial()
    {
        int resultat = 1;
        if (_factorialValue < 0 || _factorialValue > 20)
        {
            Debug.Log("Erreur : la valeur doit être comprise entre 0 et 20.");
            return;
        }
        else
        {
            for (int i = 1; i < _factorialValue + 1; i++)
            {
                resultat = resultat * i;
            }
        }
        Debug.Log(resultat);
    }

    public void BubbleSort()
    {
        Debug.Log("Avant tri : " + string.Join(", ", Table));

        for (int i = 0; i < Table.Length - 1; i++)
        {
            for (int p = 0; p < Table.Length - 1 - i; p++)
            {
                if (Table[p] > Table[p + 1])
                {
                    int temp = Table[p];
                    Table[p] = Table[p + 1];
                    Table[p + 1] = temp;
                }
            }
        }

        Debug.Log("Tableau trié : " + string.Join(", ", Table));
    }

}

