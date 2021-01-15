using UnityEngine;

public interface IPlayableAudioSource
{
    AudioSource AudioSource { get; }
}
public interface IHurteable : IPlayableAudioSource
{
    AudioClip HurtAudio { get; }
}

public interface IShoter : IPlayableAudioSource
{
    AudioClip ShotAudio { get; }
}

public interface IKilleable : IPlayableAudioSource
{    
    AudioClip DieAudio { get; }
}

public class CharacterExample : MonoBehaviour, IHurteable, IShoter, IKilleable
{
    [SerializeField] AudioClip _hurtAudio;
    [SerializeField] AudioClip _shotAudio;
    [SerializeField] AudioClip _dieAudio;

    [SerializeField] AudioSource _audioSource;


    public AudioClip HurtAudio => _hurtAudio;
    public AudioClip ShotAudio => _shotAudio;
    public AudioClip DieAudio => _hurtAudio;

    public AudioSource AudioSource => _audioSource;
}

public class AudioManager : MonoBehaviour
{
    void PlayHurtAudio(IHurteable hurteable)
    {
        hurteable.AudioSource.PlayOneShot(hurteable.HurtAudio);
    }

    void PlayDieAudio(IKilleable killeable)
    {
        killeable.AudioSource.PlayOneShot(killeable.DieAudio);
    }

    void PlayShotAudio(IShoter shoter)
    {
        shoter.AudioSource.PlayOneShot(shoter.ShotAudio);
    }
}
