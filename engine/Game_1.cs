using System;
using System.Collections.Generic;

namespace Engine.Game {
    public struct Vector2 {
        public int X, Y;
    }
    // class of modules attachable 
    // to GameObject
    public class ObjectModule {

    }
    // base class for all in-game objects
    public class GameObject {
        public string Name; 
        public Vector2 position, size;

        int left, right, top, bottom;
        public GameObject(string name) {
            Name = name;
        }
        // change the size and position of this GameObject
        public void ChangePos(Vector2 pos, Vector2 size) {
            position = pos;
            this.size = size;
            
            // get left, right, top, and bottom values
            top = position.Y;
            left = position.X;
            // slightly harder to calculate values
            right = position.X + size.X;
            bottom = position.Y + size.Y;
        }
    }
}