using MonkEngine.Core;
using Raylib_cs;

namespace MonkEngine.Components;

public class MusicPlayerComponent {
    private Music _music;

    public void SetMusicAsset(string musicAssetName) {
        _music = Engine.Assets.GetMusicAsset(musicAssetName);
    }

    public void Play() {
        Engine.Audio.PlayMusic(_music);
    }

    public void Update() {
        Engine.Audio.UpdateMusicStream(_music);
    }
}