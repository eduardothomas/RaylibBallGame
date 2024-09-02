using Raylib_cs;

using static Raylib_cs.Raylib;

namespace BallGame;

class Program
{
    public static void Main()
    {
        int ballX = 400;
        int ballY = 400;
        
        InitWindow(width: 1280, height:768, "My First Ball Game");
        SetTargetFPS(60);

        while (!WindowShouldClose())
        {
            ballX += 10;
            
            BeginDrawing();
            ClearBackground(Color.SkyBlue);
            
            DrawCircle(ballX, 400, 20, Color.Red);
            
            EndDrawing();
        }
    }
}
