using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CelebrationParticle{
    public class CelebrationParticleEngine : MonoBehaviour
    {
        [SerializeField] ParticleSystem particleSys;

        private void OnTriggerEnter2D(Collider2D other) {
            particleSys.Play();
    
        }

    }

}