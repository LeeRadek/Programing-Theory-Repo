using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Building : MonoBehaviour
{
    Canvas canvas;
    [SerializeField]
    Slider slider;
    [SerializeField]
    Text text;
    bool isSelected = false;

    public new string name;


    private void Awake()
    {
        GetComp();
        SetName(name);

    }
    void Start()
    {
        HideLabel();
    }

    
    void Update()
    {
        
    }

    public void SelectObject(bool selected)
    {
        isSelected = selected;
        if (isSelected)
        {
            canvas.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            canvas.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    public void SetName(string name)
    {

        text.text = name;
    }

    public void GetComp()
    {
        slider = GetComponentInChildren<Slider>();
        text = GetComponentInChildren<Text>();
        canvas = GetComponentInChildren<Canvas>();
    }

    public void HideLabel()
    {
        canvas.gameObject.SetActive(false);
    }

    public void ShowLabel()
    {
        canvas.gameObject.SetActive(true);
    }
}
