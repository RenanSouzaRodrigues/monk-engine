using MonkEngine.Entities;

namespace MonkEngine.Scene;

public class MainMenuScene : IScene {
    private List<IEntity> _entities = new();

    public void InitEntities() {
        _entities.ForEach(entity => entity.Init());
    }

    public void UpdateSceneEntities(float deltaTime) {
        _entities.ForEach(entity => entity.Update(deltaTime));
    }

    public void DrawSceneEntities() {
        _entities.ForEach(entity => entity.Draw());
    }

    public void DestroyEntities() {
        _entities.ForEach(entity => entity.Destroy());
    }
}