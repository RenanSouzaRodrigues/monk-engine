namespace MonkEngine.Entities;

public interface IEntity  {
    void Init();
    
    void Update(float deltaTime);

    void Draw();

    void Destroy();
}