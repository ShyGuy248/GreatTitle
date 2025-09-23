// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("eyes");
            Window.SetSize(600, 600);
            Window.TargetFPS = 30;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            DrawEyeball(100, 100);
            DrawEyeball(300, 100);
        }
        void DrawEyeball(int x, int y)
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;

            Draw.Circle(x, y, 50.0f);

            Draw.FillColor = Color.Black;
            Draw.Circle(x, y, 25.0f);
        }
    }

}
