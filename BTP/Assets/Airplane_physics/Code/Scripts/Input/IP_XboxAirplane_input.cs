using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
    { 
    public class IP_XboxAirplane_input : IP_BaseAirplane_input

    {
        #region variables
        public float throttleSpeed = 0.1f;
        private float stickyThrottle;
        public float StickyThrottle
        {
            get { return stickyThrottle; }
        }
        #endregion
        protected override void HandleInput()
        {
            //process main input
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");
            yaw = Input.GetAxis("X_RH_stick");
            throttle = Input.GetAxis("X_RV_stick");

            //process control input
            brake = Input.GetAxis("Fire1");

            //process flap input
            if (Input.GetButtonDown("X_R_Bumper"))
            {
                flaps += 1;
            }
            if (Input.GetButtonDown("X_L_Bumper"))
            {
                flaps -= 1;
            }
            flaps = Mathf.Clamp(flaps, 0, maxFlapIncrements);
        }
        void StickyThrottleControl()
        {
            stickyThrottle = stickyThrottle + (-throttle*throttleSpeed*Time.deltaTime);
            stickyThrottle = Mathf.Clamp01(stickyThrottle);
            Debug.Log(stickyThrottle);
        }
    }
}