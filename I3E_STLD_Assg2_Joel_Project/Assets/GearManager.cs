
/*
 * Author: Leo Shao Wei Joel
 * Date: 30/06/2024
 * Description: Increase gear canva number by 1 
 */using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GearManager : MonoBehaviour
{
    public static GearManager instance;
    private int gears;
    [SerializeField] private TMP_Text gearsDisplay;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    private void OnGUI()
    {
        gearsDisplay.text = gears.ToString();
    }
    public void ChangeGears(int amount)
    {
        gears += amount;
    }

}
