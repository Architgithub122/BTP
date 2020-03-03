using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IndiePixel
{ 
    public class IP_Airplane_Propeller : MonoBehaviour
    {
        #region Variables
        #endregion

        #region Builtin Methods
        #endregion

        #region Custom Methods
        public void HandlePropeller(float currentRPM)
        {
            float dps = ((currentRPM * 360f) / 60f) * Time.deltaTime;
            transform.Rotate(Vector3.forward, dps);
        }
        #endregion
    }
}
