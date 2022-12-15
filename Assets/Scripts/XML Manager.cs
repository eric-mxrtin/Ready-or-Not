using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

/// <summary>
/// Class <c>XMLManager</c> manages the leaderboard
/// </summary>
public class XMLManager : MonoBehaviour
{
    /// <summary>
    /// Initializes XML manager to be used
    /// </summary>
    public static XMLManager instance;
    /// <summary>
    /// Initializes leaderboard perameter to be used
    /// </summary>
    public Leaderboard leaderboard;

    /// <summary>
    /// Creates directory for highscores if one does not presently exist
    /// </summary>
    void Awake()
    {
        instance = this;
        if (!Directory.Exists(Application.persistentDataPath + "/HighScores/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/HighScores/");
        }
    }

    /// <summary>
    /// Saves score to leaderboard page
    /// </summary>
    /// <param><c>serializer</c> initializes a new leaderboard for unity </param>
    /// <param><c>stream</c> updates serializer when new score is given </param>
    public void SaveScores(List<float> scoresToSave)
    {
        leaderboard.list = scoresToSave;
        XmlSerializer serializer = new XmlSerializer(typeof(Leaderboard));
        FileStream stream = new FileStream(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Create);
        serializer.Serialize(stream, leaderboard);
        stream.Close();
    }

    /// <summary>
    /// Saves score to leaderboard page
    /// </summary>
    /// <param><c>serializer</c> initializes a new leaderboard for unity </param>
    /// <param><c>stream</c> updates serializer when new score is given </param>
    /// <returns>
    /// New leaderboard list
    /// </returns>
    public List<float> LoadScores()
    {
        if (File.Exists(Application.persistentDataPath + "/HighScores/highscores.xml"))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Leaderboard));
            FileStream stream = new FileStream(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Open);
            leaderboard = serializer.Deserialize(stream) as Leaderboard;
        }
        return leaderboard.list;
    }
}
[System.Serializable]

/// <summary>
/// Class <c>Leaderboard</c> updates leaderboard list
/// </summary>
/// <param><c>list</c> stores new list when board is updated </param>
public class Leaderboard
{
    public List<float> list = new List<float>();
}