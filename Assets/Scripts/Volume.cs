using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Volume : MonoBehaviour
{
    [SerializeField] private AudioSource audio_source;
    [SerializeField] private static float music_volume = 0.5f;
    [SerializeField] private Slider s;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audio_source = GetComponent<AudioSource>();
/*        if (SceneManager.GetActiveScene().name == "Main")
        {
            if (GameObject.FindGameObjectWithTag("Setting") != null)
            {
                music_volume = Setting.volume;
            }
            s.value = music_volume;
        }*/

    }
    void Update()
    {
        audio_source.volume = music_volume;
        if (s == null || !s)
        {
            s = GameObject.FindGameObjectWithTag("slider").GetComponent<Slider>();
        }
    }

    public void AdjustVolume()
    {
        float volume_level = s.value;
        music_volume = volume_level;
    }

    public float GetVolume()
    {
        return music_volume;
    }
}
