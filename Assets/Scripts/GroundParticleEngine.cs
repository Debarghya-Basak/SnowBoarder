using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GroundParticles{
    public class GroundParticleEngine : MonoBehaviour
    {
        [SerializeField] ParticleSystem particleSys;

        private void OnCollisionEnter2D(Collision2D other) {
            
            particleSys.Play();

        }

        private void OnCollisionExit2D(Collision2D other) {
            
            particleSys.Pause();
        }
    }
}