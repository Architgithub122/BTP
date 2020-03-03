using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace IndiePixel
{
    [CustomEditor(typeof(IP_XboxAirplane_input))]
    public class IP_XboxAirplaneInput_editor : Editor
    {
        #region Variables
        private IP_BaseAirplane_input targetInput;
        #endregion

        #region BuiltIn Methods
        void OnEnable()
        {
            targetInput = (IP_BaseAirplane_input)target;
        }
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            string debugInfo = "";
            debugInfo += "Pitch =" + targetInput.Pitch + "\n";
            debugInfo += "Yaw =" + targetInput.Yaw + "\n";
            debugInfo += "Roll =" + targetInput.Roll + "\n";
            debugInfo += "Throttle =" + targetInput.Throttle + "\n";
            debugInfo += "Brake =" + targetInput.Brake + "\n";
            debugInfo += "Flaps =" + targetInput.Flaps + "\n";

            //Custom input
            GUILayout.Space(10);
            EditorGUILayout.TextArea(debugInfo, GUILayout.Height(200));
            GUILayout.Space(10);

            Repaint();
        }
        #endregion

    }
}