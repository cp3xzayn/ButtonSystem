using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu(fileName = "EnemyData", menuName = "Data/EnemyData")]
public class EnemyData : ScriptableObject
{
    public List<EnemyStatus> EnemyStatusList = new List<EnemyStatus>();
}

/// <summary>
/// 敵の情報
/// </summary>
[Serializable]
public class EnemyStatus
{
    public string name;
    public int hp;
    public int attack;
    public int defense;
} 
