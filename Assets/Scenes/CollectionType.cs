using System;
using UnityEngine;
using static EnumDay;

public class CollectionType : MonoBehaviour
{
    [SerializeField] private EnumCollectionType type;
    EnumCollectionType IColleciton;
    public enum EnumCollectionType
    {
        Array,
        list,
        Stack,
        Queue,
        HashSet
    }

    private void Start()
    {
        IColleciton = type;
        ContextMenu();
    }

    void ContextMenu()
    {
        {
            foreach (EnumCollectionType type in Enum.GetValues(typeof(EnumCollectionType)))
            {
                Debug.Log(type);
            }
        }
    }
}