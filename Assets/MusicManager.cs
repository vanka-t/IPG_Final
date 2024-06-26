using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VanessaMusic.Utilities
{
    


    public class MusicManager : MonoBehaviour
    {
        public static MusicManager instance;

        AudioSource source;

        public AudioClip bgMusic1;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this);

            }
            else
            {
                Destroy(gameObject);

            }

            source = GetComponent<AudioSource>();


        }

        private void Update()
        {
            //if (GameManager.instance.levelCount == 0)
            //{

            //}
        
        }

        public void SwitchMusic(AudioClip aClip)
        {
            source.clip = aClip;
            source.Play();
        }
    }


}
