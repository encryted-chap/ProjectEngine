using SFML.Graphics;
using SFML.Window;
using SFML;
using System;

namespace Engine.Core {
    public class Window {
        /// <summary>
        /// Initializes a window using width and height,
        /// if either value = 0, initialize to full screen
        /// </summary>
        /// <param name="h"></param>
        /// <param name="w"></param>
        public Window(int w=0, int h=0, uint bpp=32) {
            
            VideoMode v;
            if(h==0 || w==0) {
                v = VideoMode.FullscreenModes[0];
            } else {
                v = new VideoMode((uint)w, (uint)h, bpp);
            }
            RenderWindow window = new RenderWindow(v, "");
            window.Display();

            Engine.Debug.LogSuccess($"Initialized Window with w={v.Width},h={v.Height},bpp={v.BitsPerPixel}");
        }
    }
}