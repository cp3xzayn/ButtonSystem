using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class BattleManager : MonoBehaviour
{
    /// <summary> ランダムで敵を生成する時管理するためのint </summary>
    [SerializeField] private int m_randomNum;
    /// <summary> 敵の種類の数 </summary>
    [SerializeField] private int m_enemyTypeNum = 2;


    [SerializeField] string eneName = null;
    [SerializeField] int eneHP = 0;
    [SerializeField] int eneAttack = 0;
    [SerializeField] int eneDefense = 0;
    /// <summary> EnemyData </summary>
    [SerializeField] EnemyData m_enemyData = null;

    [SerializeField] int m_playerHP = 10;
    [SerializeField] int m_playerAttack = 5;

    private void EnemyGenerate()
    {
        m_randomNum = Random.Range(0, m_enemyTypeNum);
        Debug.Log(m_randomNum);
        eneName = m_enemyData.EnemyStatusList[m_randomNum].name;
        eneHP = m_enemyData.EnemyStatusList[m_randomNum].hp;
        eneAttack = m_enemyData.EnemyStatusList[m_randomNum].attack;
        eneDefense = m_enemyData.EnemyStatusList[m_randomNum].defense;

        Debug.Log($"敵{eneName}が出現");
        Debug.Log($"敵のHPは{eneHP}");
        Debug.Log($"敵の攻撃力は{eneAttack}");
        Debug.Log($"敵の防御力は{eneDefense}");
    }
}
