using UnityEngine;

/// <summary>
/// Movement for the AI to follow the player
/// </summary>
public class Follow_player : MonoBehaviour {

    /// <summary>
    /// Initializes the change of position perameter for the bot
    /// </summary>
    public Transform player;

    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + new Vector3(0, 1, -5);
    }
}