using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DropTable", menuName = "Scriptable Objects/DropTable")]
public class DropTable : ScriptableObject
{
    [SerializeField]
    [DictionaryHeader(keyColumnLabel = "Item", valueColumnLabel = "Drop chance", keyColumnFraction = 0.6f)]
    private Dictionary<string, float> drops = new Dictionary<string, float>();
}
