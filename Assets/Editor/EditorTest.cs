using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BattleManager))]
public class EditorTest : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        BattleManager randomNum = target as BattleManager;

        if (GUILayout.Button("敵を生成"))
        {
            randomNum.SendMessage("EnemyGenerate", null, SendMessageOptions.DontRequireReceiver);
        }
    }
}
