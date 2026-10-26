using UnityEngine;

public class PlayerAttribs : MonoBehaviour
{
    [field: Range(0, 100)]
    [field: SerializeField]
    [field: Tooltip("The health of the player.")]
    public float Health { get; private set; }
    
    /// <summary>
    /// Returns the status of the player based on their health.
    /// </summary>
    public (string, Color) Status => Health switch
    {
        0 => ("Player is Dead", Color.gray),
        >= 1 and < 30 => ("Critical Health", Color.red),
        >= 30 and < 70 => ("Injured", new Color(1f, 0.5f, 0f)),
        >= 70 => ("Healthy", Color.green),
        _ => ("Invalid Health Value", Color.white)
    };
}
