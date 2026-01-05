using UnityEngine;

public class ArraysCollectionsEnumsExercice : MonoBehaviour
{
    [SerializeField] string[] table = new string[10];


    private void Start()
    {
        ContextMenu();
    }

    void ContextMenu() 
    { 
        if (table == null)
        {
            table = new string[10];
        }
        if (table.Length != 10)
        {
            string[] newTable = new string[10];
            int count = Mathf.Min(table.Length, 10);

            for (int i = 0; i < count; i++)
            {
                newTable[i] = table[i];
            }
            table = newTable;
        }
        for (int i = 0; i < table.Length; i++)
        {
            Debug.Log(table[i]);
        }
    }
}
