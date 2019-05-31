using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDataBehaviour : MonoBehaviour {

    public Button Add;
    public Button Subtract;
    public Button Save;
    public Button Load;

	// Use this for initialization
	void Start ()
    {
        Add.onClick.AddListener(AddNumb);
        Subtract.onClick.AddListener(SubNumb);
        Save.onClick.AddListener(SavNumb);
        Load.onClick.AddListener(LodNumb);
	}
	
    void AddNumb()
    {

    }

    void SubNumb()
    {

    }

    void SavNumb()
    {

    }

    void LodNumb()
    {

    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}
