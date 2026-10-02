using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    private void OnGUI()
    {
        if(GUI.Button(new Rect(10, 100, 100, 30), "Health up"))
        {
            GameManager.control.health += 10;
        }
        if (GUI.Button(new Rect(120, 100, 100, 30), "Health down"))
        {
            GameManager.control.health -= 10;
        }
        if (GUI.Button(new Rect(10, 140, 100, 30), "Experience up"))
        {
            GameManager.control.experience += 10;
        }
        if (GUI.Button(new Rect(120, 140, 100, 30), "Experience down"))
        {
            GameManager.control.experience -= 10;
        }
        if (GUI.Button(new Rect(10, 180, 100, 30), "Score up"))
        {
            GameManager.control.score += 10;
        }
        if (GUI.Button(new Rect(120, 180, 100, 30), "Score down"))
        {
            GameManager.control.score -= 10;
        }
        if (GUI.Button(new Rect(10, 220, 100, 30), "Magic up"))
        {
            GameManager.control.magic += 10;
        }
        if (GUI.Button(new Rect(120, 220, 100, 30), "Magic down"))
        {
            GameManager.control.magic -= 10;
        }
        if (GUI.Button(new Rect(10, 260, 100, 30), "Speed up"))
        {
            GameManager.control.speed += 10;
        }
        if (GUI.Button(new Rect(120, 260, 100, 30), "Speed down"))
        {
            GameManager.control.speed -= 10;
        }
        if (GUI.Button(new Rect(10, 300, 100, 30), "Defense up"))
        {
            GameManager.control.defense += 10;
        }
        if (GUI.Button(new Rect(120, 300, 100, 30), "Defense down"))
        {
            GameManager.control.defense -= 10;
        }
        if (GUI.Button(new Rect(10, 340, 100, 30), "Save"))
        {
            GameManager.control.Save();
        }
        if (GUI.Button(new Rect(10, 380, 100, 30), "Load"))
        {
            GameManager.control.Load();
        }
    }
}
