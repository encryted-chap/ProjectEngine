

namespace Engine.Game {
    public struct Vector2 {
        int X, Y;
    }
    // base class for all in-game objects
    public class GameObject {
        public string Name; 
        public Vector2 position, size;

        int left, right, top, bottom;
        public GameObject(string name) {

        }
    }
}