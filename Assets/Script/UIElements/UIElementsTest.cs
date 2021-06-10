using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

public class UIElementsTest : EditorWindow
{
    [MenuItem("Window/ UIElementsTest")]
    public static void ShowWindow() => GetWindow<UIElementsTest>("UIElementsTest");

    // この文字列とラベルのテキストを紐づける
    [SerializeField] private string m_bindingText;

    private int m_clickCount = 0;

    private void OnEnable()
    {
        // ルートとなるVisualElementを取得
        var root = rootVisualElement;
        root.styleSheets.Add(Resources.Load<StyleSheet>("USS_Example"));
        var visualTree = Resources.Load<VisualTreeAsset>("UXML_Example");
        visualTree.CloneTree(root);

        //このクラスのSerializeFieldとVisualElementをバインドする
        root.Bind(new SerializedObject(this));
        //クリックされる旅にバインドされた文字列に変更を加える
        root.Q<Button>().clickable.clicked += () => {
            m_bindingText = $"{m_clickCount++}";
        };
    }
}
