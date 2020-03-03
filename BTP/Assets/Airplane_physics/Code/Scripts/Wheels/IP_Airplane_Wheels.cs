using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    [RequireComponent(typeof(WheelCollider))]
    public class IP_Airplane_Wheels : MonoBehaviour
    {
        #region variables
        private WheelCollider WheelCol;
        #endregion

        #region BuiltinMethods
        void Start()
        {
            WheelCol = GetComponent<WheelCollider>();  
        }
        #endregion

        #region CustomMethods
        public void Initwheel()
        {
            if (WheelCol)
            {
                WheelCol.motorTorque = 0.000000001f;

            }
        }
        #endregion
    }
}