using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager control;

    public float health;
    public float experience;
    public float score;
    public float magic;
    public float speed;
    public float defense;

    void Awake()
    {
        // if the control doesn't exist, it is now this. If it does and it isn't this, destroy it.
        // This is also a singleton
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        // A basic debugging script to manually switch scenes.
        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene(0); // press 1
        if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene(1); // press 2
        if (Input.GetKeyDown(KeyCode.Alpha3)) SceneManager.LoadScene(2); // press 3
        if (Input.GetKeyDown(KeyCode.Alpha4)) SceneManager.LoadScene(3); // press 4
    }

    private void OnGUI()
    {
        // OnGUI is automatically called like Update, this takes a position and text
        // This is specifically just the text boxes that show the values in game.
        GUI.Label(new Rect(10, 10, 150, 30), "Health: " + health);
        GUI.Label(new Rect(10, 40, 150, 30), "Experience: " + experience);
        GUI.Label(new Rect(200, 10, 150, 30), "Score: " + score);
        GUI.Label(new Rect(200, 40, 150, 30), "Magic: " + magic);
        GUI.Label(new Rect(400, 10, 150, 30), "Speed: " + speed);
        GUI.Label(new Rect(400, 40, 150, 30), "Defense: " + defense);
    }

    public void Save()
    {
        // BinaryFormatter takes information and converts it into bytes that can be converted back into info again
        BinaryFormatter bf = new BinaryFormatter();

        // I believe persistentDataPath is a Unity specific folder that will hold our information
        // playerInfo is where it's located?
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        // this is just our data and each variable
        PlayerData data = new PlayerData();
        data.health = health;
        data.experience = experience;
        data.score = score;
        data.magic = magic;
        data.speed = speed;
        data.defense = defense;

        // This takes the above variables and includes it into the file, then closes it.
        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        // If a file exists in our specific data path
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            health = data.health;
            experience = data.experience;
            score = data.score;
            magic = data.magic;
            speed = data.speed;
            defense = data.defense;
        }
    }
}

[Serializable]
class PlayerData
{
    public float health;
    public float experience;
    public float score;
    public float magic;
    public float speed;
    public float defense;
}