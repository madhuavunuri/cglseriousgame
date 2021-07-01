using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "universitiesData",menuName = "Create UniData")]
public class UniversitiesData : ScriptableObject
{
    public UniDetails[] uniDetails;
}

[System.Serializable]
public class UniDetails
{
    public string collegeName;
    public string course;
    public string address;
    public string requriments;
    public string info;
    public int deadline;
}
