using UnityEngine;
using UnityEngine.Rendering;

public class MusicManger : MonoBehaviour
{
    private const string PLAYER_PREFS_MUSIC_VOLUME = "MusicVolume";
    public static MusicManger Instance { get; private set; } // Singleton instance

    private AudioSource audioSource;
    private float volume =0.3f;


    private void Awake()
    {
        Instance = this; // Set the singleton instance
        audioSource = GetComponent<AudioSource>();

        volume = PlayerPrefs.GetFloat(PLAYER_PREFS_MUSIC_VOLUME, .3f);
        audioSource.volume = volume;
        
    }
    public void ChangeVolume()
    {
        volume += 0.1f;
        if (volume > 1f)
        {
            volume = 0f;
        }
        audioSource.volume = volume;
        PlayerPrefs.SetFloat(PLAYER_PREFS_MUSIC_VOLUME,volume);
        PlayerPrefs.Save();

    }
    public float GetVolume()
    {
        return volume;
    }
}
