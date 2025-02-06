using Raylib_cs;

namespace MonkEngine.Core; 

public class DebugHandler {
    public void ShowFPS() {
        Raylib.DrawFPS(10, 10);
    }
}