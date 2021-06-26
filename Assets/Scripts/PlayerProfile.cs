using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="new PLayer Profile", menuName= "Player Profiles")]
public class PlayerProfile : ScriptableObject
{
    public new string name;
    public int age;
    public int sex;
    public int education; 
    public List<string> skills;
}
