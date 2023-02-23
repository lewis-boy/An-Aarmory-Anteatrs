using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] private GameObject _settingsMenu;
    private bool menuToggle;

    // Start is called before the first frame update
    void Start()
    {
        menuToggle = false;
        _settingsMenu.SetActive(menuToggle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleSettings()
    {
        menuToggle = !menuToggle;
        _settingsMenu.SetActive(menuToggle);
    }
}
