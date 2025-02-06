using Raylib_cs;

namespace MonkEngine.Core;

public class AudioHandler {
    public AudioHandler() {
        Raylib.InitAudioDevice();
    }

    public void Destroy() {
        Raylib.CloseAudioDevice();
    }

    public void PlayMusic(Music musicInstance) {
        Raylib.PlayMusicStream(musicInstance);
    }

    public void UpdateMusicStream(Music musicInstance) {
        Raylib.UpdateMusicStream(musicInstance);
    }
}