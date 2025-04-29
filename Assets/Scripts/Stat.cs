using System.Collections.Generic;
using UnityEngine;

//makes it visable in inspector
[System.Serializable]
public class Stat 
{
    [SerializeField] private int baseValue;

    public List<int> modifiers;
    public int GetValue()
    {
        int finalValue = baseValue;

        foreach (int modifier in modifiers)
        {
            finalValue += modifier;
        }

        return finalValue;
    }


    public void AddModifier(int _modifier)
    {
        modifiers.Add(_modifier);
    }

    public void RemoveModifier(int _modifier)
    {
        modifiers.RemoveAt(_modifier);
    }
}
