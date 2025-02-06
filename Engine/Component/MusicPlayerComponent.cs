using MonkEngine.Core;
using Raylib_cs;

namespace MonkEngine.Components;

public class MusicPlayerComponent {
    private Music _music;

    public void SetMusicAsset(string musicAssetName) {
        _music = AssetHandler.GetMusicAsset(musicAssetName);
    }

    public void Play() {
        
    }
}