using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IndiePixel
{
    public class IP_BaseAirplane_input : MonoBehaviour
    {
        #region Variables
        public float throttleSpeed = 0.1f;
        protected float stickyThrottle;
        public float StickyThrottle
        {
            get { return stickyThrottle; }
        }

        protected float pitch = 0f;
        protected float roll = 0f;
        protected float yaw = 0f;

        protected int maxFlapIncrements=2;
        protected int flaps = 0;
        protected float throttle = 0f;
        protected float brake = 0f;
        #endregion

        #region Properties
        public float Pitch
        {
            get { return pitch; }
        }
        public float Roll
        {
            get { return roll; }
        }
        public float Yaw
        {
            get { return yaw; }
        }
        public int Flaps
        {
            get { return flaps; }
        }
        public float Throttle
        {
            get { return throttle; }
        }
        public float Brake
        {
            get { return brake; }
        }
        #endregion

        #region Builtin_Methods
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            HandleInput();
        }
        #endregion

        #region Custom Methods
        protected virtual void HandleInput()
        {
            //process main input
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");
            yaw= Input.GetAxis("Yaw");
            throttle= Input.GetAxis("Throttle");

            //process control input
            brake =(Input.GetKey(KeyCode.Space))? 1f : 0f;

            //process flap input
            if(Input.GetKeyDown(KeyCode.F))
            {
                flaps += 1;
            }
            if(Input.GetKeyDown(KeyCode.G))
            {
                flaps -= 1;
            }
            flaps = Mathf.Clamp(flaps, 0, maxFlapIncrements);
        }
        void StickyThrottleControl()
        {
            stickyThrottle = stickyThrottle + (-throttle * throttleSpeed * Time.deltaTime);
            Debug.Log(stickyThrottle);
        }
    }

    #endregion
}
