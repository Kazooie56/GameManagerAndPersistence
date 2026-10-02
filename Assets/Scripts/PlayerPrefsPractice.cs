using UnityEngine;

public class PlayerPrefsPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.SetInt("health", 100);
        int x = PlayerPrefs.GetInt("health");

        // PlayerPrefs are not secure, it's just a plain text file
        // slow, noob way to save data apparently
        // use for non-important data like player preferences, if it gets destroyed then whatevz
    }
}
