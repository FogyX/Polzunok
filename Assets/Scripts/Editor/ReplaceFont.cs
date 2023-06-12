using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Editor
{
    public class ReplaceFont : EditorWindow
    {
        private Font _oldFont;
        private Font _newFont;
        
        [MenuItem("Tools/Replace Font")]
        private static void ShowWindow()
        {
            var window = GetWindow<ReplaceFont>();
            window.titleContent = new GUIContent("Replace font");
            window.Show();
        }

        private void OnGUI()
        {
            _oldFont = (Font)EditorGUILayout.ObjectField("Old font", _oldFont, typeof(Font), false);
            _newFont = (Font)EditorGUILayout.ObjectField("New font", _newFont, typeof(Font), false);

            if (GUILayout.Button("Change font"))
            {
                Text[] texts = FindObjectsOfType<Text>();

                foreach (var text in texts)
                {
                    if (text.font == _oldFont)
                        text.font = _newFont;
                }
            }
        }
    }
}