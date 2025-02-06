using MonkEngine.Entities;

namespace MonkEngine.Scene;

public interface IScene {
    void InitEntities();
    void UpdateSceneEntities(float deltaTime);
    void DrawSceneEntities();
    void DestroyEntities();
}