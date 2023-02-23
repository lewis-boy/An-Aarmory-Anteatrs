using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaScript : MonoBehaviour
{
    [SerializeField] private GameObject _gachaMenu;
    private bool menuToggle;
    
    // Start is called before the first frame update
    void Start()
    {
        menuToggle = false;
        _gachaMenu.SetActive(menuToggle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleGacha()
    {
        menuToggle = !menuToggle;
        _gachaMenu.SetActive(menuToggle);
    }
}
