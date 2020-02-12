using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text startext;
    void Start()
    {
        startext = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        startext.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public bool HaveEnoughStars( int amount)
    {
        return stars >= amount;
    }

    public void SpendStars(int amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
        
    }
    
}
