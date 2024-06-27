using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeView : BaseView
{
    [SerializeField] AudioSource audio_source;
    [SerializeField] AudioSource audio_source_button_sounds;
    public Image sound;
    bool isPlayingAudio;
    public override void Setup(ViewParam param)
    {
        base.Setup(param);
        isPlayingAudio = true;
    }
    public void OnPlayGame()
    {

    }
    public void OnSettings()
    {
        DialogManager.instance.ShowDialog(DialogIndex.SettingsDialog);
    }
    public void OnCloseMusic()
    {
        audio_source_button_sounds.Play();
        if (isPlayingAudio)
        {
            audio_source.Pause();
            sound.overrideSprite = SpriteLibControl.instance.GetSpriteByName("Inactive");
        }
        else
        {
            audio_source.UnPause();
            sound.overrideSprite = SpriteLibControl.instance.GetSpriteByName("Blue");
        }
        isPlayingAudio = !isPlayingAudio;
    }
}
