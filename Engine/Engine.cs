using Raylib_cs;
using MonkEngine.Entities;
using System.Numerics;
using MonkEngine.Utils;

namespace MonkEngine;

public class Engine {
    private readonly string _gameName;
    private readonly List<IEntity> _gameEntities = [];
    private float _deltaTime;
    private bool _debug = false;

    public Engine(string gameName = "Monk Engine") {
        _gameName = gameName;
    }

    public void AddNewGameEntity(IEntity newEntity) {
        _gameEntities.Add(newEntity);
    }

    public void EnableDebug() => _debug = true;

    public void StartEngine() {
        Raylib.InitWindow(1920, 1080, _gameName);
        Raylib.InitAudioDevice();

        _gameEntities.ForEach(entity => entity.Init());

        var mainMenuBackground = Raylib.LoadTexture(Assets.GetTextureAssetPath("mainMenuBackground.png"));
        Music music = Raylib.LoadMusicStream(Assets.GetSoundAssetPath("Song1.mp3"));
        music.Looping = true;
        Raylib.PlayMusicStream(music);

        while (!Raylib.WindowShouldClose()) {
            _deltaTime = Raylib.GetFrameTime();
            _gameEntities.ForEach(entity => entity.Update(_deltaTime));

            Raylib.UpdateMusicStream(music);

            Raylib.BeginDrawing();
            
            Raylib.ClearBackground(new Color(12, 19, 23, 255));

            Raylib.DrawTexture(mainMenuBackground, 0, 0, Color.White);
            
            Raylib.DrawText("Lightless", 730, 300, 100, Color.White);

            
            _gameEntities.ForEach(entity => entity.Draw());


            if (_debug) {
                Raylib.DrawFPS(10, 10);
            }

            Raylib.EndDrawing();
        }

        Raylib.CloseAudioDevice();
        Raylib.CloseWindow();
        _gameEntities.ForEach(entity => entity.Destroy());
    }
}