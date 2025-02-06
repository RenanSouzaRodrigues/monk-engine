using MonkEngine.Core;
using Raylib_cs;

namespace MonkEngine.ECS.NativeComponents;

public class MusicPlayerComponent : IComponent {
    private Music _music;

    public void SetMusicAsset(string folder, string fileName) {
        _music = Engine.Assets.LoadMusic(folder, fileName);
    }

    public void Play() {
        Engine.Audio.PlayMusic(_music);
    }

    public void Update() {
        Engine.Audio.UpdateMusicStream(_music);
    }
}