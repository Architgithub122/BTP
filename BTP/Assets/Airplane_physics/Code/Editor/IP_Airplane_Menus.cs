using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
namespace IndiePixel
{ 
public class IP_Airplane_Menus : MonoBehaviour
{
        [MenuItem("Airplane Tools/Create New Airplane")]
        public static void CreateNewAirplane()
        {
            GameObject curSelected = Selection.activeGameObject;
            if(curSelected)
            {
                curSelected.AddComponent<IP_Airplane_Controller>();
            }
        }

}
}
