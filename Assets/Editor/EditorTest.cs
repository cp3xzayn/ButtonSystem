using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BattleManager))]
public class EditorTest : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        BattleManager battleManager = target as BattleManager;

        if (GUILayout.Button("敵を生成"))
        {
            battleManager.SendMessage("EnemyGenerate", null, SendMessageOptions.DontRequireReceiver);
        }
        if (GUILayout.Button("バトル開始"))
        {
            battleManager.SendMessage("BattleStart", null, SendMessageOptions.DontRequireReceiver);
        }
        if (GUILayout.Button("リセット"))
        {
            battleManager.SendMessage("ResetStatus", null, SendMessageOptions.DontRequireReceiver);
        }
    }
}
