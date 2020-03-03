using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{ 
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(AudioSource))]
    public class IP_BaseRigidBody_Controller : MonoBehaviour
    {
        #region
        protected Rigidbody rb;
        protected AudioSource aSource;
        #endregion
        // Start is called before the first frame update

        #region built in methods
        protected virtual void Start()
        {
            rb = GetComponent<Rigidbody>();
            aSource = GetComponent<AudioSource>();
            if(aSource)
            {
                aSource.playOnAwake = false;
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(rb)
            {
                HandlePhysics();
            }
        }
        #endregion

        #region Custom methods
        protected virtual void HandlePhysics(){
        }
        #endregion

    }
}