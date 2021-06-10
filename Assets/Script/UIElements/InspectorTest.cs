using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;


public class InspectorTest : MonoBehaviour
{
    public int test;
}

[CustomEditor(typeof(InspectorTest))]
public class InspectorEditor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();

        IMGUIContainer defaultInspector = new IMGUIContainer(() => DrawDefaultInspector());
        root.Add(defaultInspector);

        root.styleSheets.Add(Resources.Load<StyleSheet>("USS_Example"));
        var visualtree = Resources.Load<VisualTreeAsset>("UXML_Example");
        visualtree.CloneTree(root);
        
        return root;
    }
}
