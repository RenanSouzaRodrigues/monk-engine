using Raylib_cs;

namespace MonkEngine.Core;

public class WindowHandler {
    public void Create(string gameTitle) {
        Raylib.InitWindow(1920, 1080, gameTitle);
    }

    public void Destroy() {
        Raylib.CloseWindow();
    }

    public void BeginDraw() {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.RayWhite);
    }

    public void EndDraw() {
        Raylib.EndDrawing();
    }

    public float GetDeltaTime() => Raylib.GetFrameTime();
    
    public bool QuitApplication() {
        return Raylib.WindowShouldClose();
    }
}