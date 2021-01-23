using UnityEngine;
using UnityEditor;

namespace CustomPackage
{

    [CustomEditor(typeof(PlayerData))]
    public class PlayerDataEditor : Editor
	{

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.Space();
            if (GUILayout.Button("Click Here"))
            {
                Debug.Log("Oui");
            }
        }

    }

}