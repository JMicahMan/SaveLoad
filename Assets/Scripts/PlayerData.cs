using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewData", menuName ="Data")]
public class PlayerData : ScriptableObject
{
    public string SaveText;

    public string LoadText;

    public string AddText;

    public string SubText;

    public int numberHas;


    public int addNumb;

    public int subNumb;
}
