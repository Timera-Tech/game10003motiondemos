// Include the namespaces (code libraries) you need below.
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
            Window.SetTitle("Motion Demos");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            Draw.LineSize = 2;
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.OffWhite;

            Vector2 circlePosition = new(100, 100);

            //how fast should the circle move in pixels per second
            Vector2 circleSpeed = new(100,0);

            circlePosition += circleSpeed * Time.DeltaTime;

            Draw.Circle(circlePosition, 50);
        }
    }

}
