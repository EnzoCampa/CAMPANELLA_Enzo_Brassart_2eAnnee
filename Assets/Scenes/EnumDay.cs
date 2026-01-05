using System;
using UnityEngine;

public class EnumDay : MonoBehaviour
{
    [SerializeField] Day day;
    public enum Day
    {
        Lundi,
        Mardi,
        Mercredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche           
    }


    private void Start()
    {
        foreach (Day day in Enum.GetValues(typeof(Day)))
        {
            Debug.Log(day);
        }

    }
}
