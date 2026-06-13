using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{
    enum MyEnum
    {
        A,
        B,
        C
    }
    
    [SerializeField]
    [DictionaryHeader(keyColumnLabel = "Item", valueColumnLabel = "Drop chance", keyColumnFraction = 0.6f)]
    private Dictionary<string, float> drops = new Dictionary<string, float>();
    
    [SerializeField] private Dictionary<int, int> dictionary1;
    [SerializeField] private Dictionary<string, int> dictionary2;
    [SerializeField] private Dictionary<byte, int> dictionary3;
    [SerializeField] private Dictionary<ushort, int> dictionary4;
    [SerializeField] private Dictionary<long, int> dictionary5;
    [SerializeField] private Dictionary<uint, int> dictionary6;
    [SerializeField] private Dictionary<double, int> dictionary7;
    [SerializeField] private Dictionary<float, int> dictionary8;
    [SerializeField] private Dictionary<MyEnum, int> dictionary9;
    [SerializeField] private Dictionary<Color, int> dictionary10;
}
