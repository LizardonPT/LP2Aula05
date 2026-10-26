using UnityEngine;

public class PlayerAttribs : MonoBehaviour
{
    [field: Range(0, 100)]
    [field: SerializeField]
    public float Health { get; private set; }
}
