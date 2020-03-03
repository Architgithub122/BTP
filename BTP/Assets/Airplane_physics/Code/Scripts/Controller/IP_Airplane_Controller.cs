using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IndiePixel
{ 
    [RequireComponent(typeof(IP_Airplane_Characteristics))]
    public class IP_Airplane_Controller : IP_BaseRigidBody_Controller
    {
        #region variables
        [Header("Base airplane properties")]
        public IP_BaseAirplane_input input;
        public IP_Airplane_Characteristics characteristics;
        public Transform centerOfGravity;


        [Tooltip("Transform from lbs to kg")]
        public float airplaneWeight = 800f;

        [Header("Engines")]
        public List<IP_Airplane_Engine> engines = new List<IP_Airplane_Engine>();

        [Header("Wheels")]
        public List<IP_Airplane_Wheels> wheels = new List<IP_Airplane_Wheels>();
        #endregion

        #region Constants
        const float poundsToKilos = 0.456f;
        #endregion

        #region BuiltInMethods
        protected override void Start()
        {
            base.Start();

            float finalMass = airplaneWeight * poundsToKilos;
            if(rb)
            {
                rb.mass = finalMass;
                if(centerOfGravity)
                {
                    rb.centerOfMass = centerOfGravity.localPosition;
                }
                characteristics = GetComponent<IP_Airplane_Characteristics>();
                if(characteristics)
                {
                    characteristics.InitCharacteristics(rb,input);
                }
            }
            if(wheels!=null)
            {
                if(wheels.Count>0)
                {
                    foreach(IP_Airplane_Wheels wheel in wheels)
                    {
                        wheel.Initwheel();
                    }
                }
            }
            
        }
        #endregion

        #region Custom Methods
        protected override void HandlePhysics()
        {
           // if(input)
           // { 
                handleEngine();
                handleCharacteristics();
                handleBrakes();
                handleSteering();
                handleAltitude();
            //}
        }
        void handleEngine()
        {
            if (engines!= null)
            {
                if (engines.Count > 0)
                {
                    foreach(IP_Airplane_Engine engine in engines)
                    {
                        rb.AddForce(engine.CalculateForce(-input.Throttle));
                    }
                }
            }
        }
        void handleCharacteristics()
        {
            if(characteristics)
            {
                characteristics.UpdateCharacterisrics();
            }
        }
        void handleBrakes()
        {

        }
        void handleSteering()
        {

        }
        void handleAltitude()
        {

        }
        #endregion
    }

}