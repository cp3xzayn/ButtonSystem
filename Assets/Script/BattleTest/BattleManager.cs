using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class BattleManager : MonoBehaviour
{
    /// <summary> ランダムで敵を生成する時管理するためのint </summary>
    [SerializeField] private int m_randomNum;
    /// <summary> 敵の種類の数 </summary>
    [SerializeField] private int m_enemyTypeNum = 5;

    /// <summary> EnemyData </summary>
    [SerializeField] EnemyData m_enemyData = null;

    [Header("敵のステータス")]
    [SerializeField] string m_eneName = null;
    [SerializeField] int m_eneHP = 0;
    [SerializeField] int m_eneAttack = 0;
    [SerializeField] int m_eneDefense = 0;

    [Header("Playerのステータス")]
    [SerializeField] string m_playerName = "Player";
    [SerializeField] int m_playerHP = 10;
    [SerializeField] int m_playerAttack = 5;
    [SerializeField] int m_playerDefense = 1;


    /// <summary>
    /// 敵を生成する関数
    /// </summary>
    private void EnemyGenerate()
    {
        m_randomNum = Random.Range(0, m_enemyTypeNum);
        Debug.Log(m_randomNum);
        m_eneName = m_enemyData.EnemyStatusList[m_randomNum].name;
        m_eneHP = m_enemyData.EnemyStatusList[m_randomNum].hp;
        m_eneAttack = m_enemyData.EnemyStatusList[m_randomNum].attack;
        m_eneDefense = m_enemyData.EnemyStatusList[m_randomNum].defense;

        Debug.Log($"敵{m_eneName}が出現");
        Debug.Log($"敵のHPは{m_eneHP}");
    }

    /// <summary>
    /// Battleの処理を行う
    /// </summary>
    private void BattleStart()
    {
        Debug.Log("Playerのターン");
        PlayerAttack();
        Debug.Log("敵のターン");
        EnemyAttack();
    }

    /// <summary>
    /// Playerが攻撃する関数
    /// </summary>
    private void PlayerAttack()
    {
        int damage = m_playerAttack - m_eneDefense;
        if (m_eneHP > 0)
        {
            m_eneHP -= damage;
            if (m_eneHP <= 0)
            {
                m_eneHP = 0;
            }
        }
        Debug.Log($"Playerの攻撃、攻撃力:{m_playerAttack}");
        Debug.Log($"敵のHP:{m_eneHP}");
    }

    /// <summary>
    /// 敵が攻撃する関数
    /// </summary>
    private void EnemyAttack()
    {
        int damage = m_eneAttack - m_playerDefense;
        if (m_playerHP > 0)
        {
            m_playerHP -= damage;
            if (m_playerHP <= 0)
            {
                m_playerHP = 0;
            }
        }
        Debug.Log($"敵のの攻撃、攻撃力:{m_eneAttack}");
        Debug.Log($"PlayerのHP:{m_playerHP}");
    }
}
