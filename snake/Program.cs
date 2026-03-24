using System;
using System.Collections.Generic;

class SnakeGame
{
    private char[,] buffer = new char[25, 80];
    private int score = 0;
    private int headX = 40, headY = 12;
    private List<(int x, int y)> body = new();
    private int appleX, appleY;
    private int dirX = 1, dirY = 0; // Right
    private bool gameOver = false;
    private Random rand = new();

    public void Run()
    {
        InitGame();
        Console.WriteLine("Добро пожаловать в Змейку!");
        Console.WriteLine("Управление - W/A/S/D. | Esc - выход из игры.");
        Console.WriteLine("Нажмите любую клавишу, чтобы начать.");
        Console.ReadKey(true);

        while (!gameOver)
        {
            Update();
            Render();
            System.Threading.Thread.Sleep(85); // 85мс
            ReadInput();
        }

        ShowGameOver();
    }

    private void InitGame()
    {
        body.Clear();
        body.Add((headX, headY));
        body.Add((headX - 1, headY));
        body.Add((headX - 2, headY));
        score = 0;
        SpawnApple();
        gameOver = false;
    }

    private void Update()
    {
        // Движение головы
        headX += dirX;
        headY += dirY;

        // Столкновения
        if (headX < 1 || headX > 78 || headY < 1 || headY > 23 || body.Contains((headX, headY)))
        {
            gameOver = true;
            return;
        }

        // Добавляем голову
        body.Insert(0, (headX, headY));

        // Яблоко
        if (headX == appleX && headY == appleY)
        {
            score++;
            SpawnApple();
        }
        else
        {
            body.RemoveAt(body.Count - 1);
        }
    }

    private void SpawnApple()
    {
        do
        {
            appleX = rand.Next(2, 78);
            appleY = rand.Next(2, 23);
        } while (body.Contains((appleX, appleY)));
    }

    private void ReadInput()
    {
        if (!Console.KeyAvailable) return;
        var key = Console.ReadKey(true).Key;
        switch (key)
        {
            case ConsoleKey.W: if (dirY != 1) { dirX = 0; dirY = -1; } break;
            case ConsoleKey.S: if (dirY != -1) { dirX = 0; dirY = 1; } break;
            case ConsoleKey.A: if (dirX != 1) { dirX = -1; dirY = 0; } break;
            case ConsoleKey.D: if (dirX != -1) { dirX = 1; dirY = 0; } break;
            case ConsoleKey.Escape: gameOver = true; break;
        }
    }

    private void Render()
    {
        // Очистка буфера
        Array.Clear(buffer, 0, buffer.Length);

        // Границы
        for (int i = 0; i < 80; i++)
        {
            buffer[0, i] = '#';
            buffer[24, i] = '#';
        }
        for (int i = 0; i < 25; i++)
        {
            buffer[i, 0] = '#';
            buffer[i, 79] = '#';
        }

        // Очки
        string scoreStr = score.ToString("D2");
        buffer[1, 1] = 'S'; buffer[1, 2] = 'C'; buffer[1, 3] = 'O'; buffer[1, 4] = 'R'; buffer[1, 5] = 'E';
        buffer[1, 7] = ':'; buffer[1, 9] = scoreStr[0]; buffer[1, 10] = scoreStr[1];

        // Яблоко
        buffer[appleY, appleX] = 'O';

        // Змейка
        buffer[headY, headX] = '@';
        foreach (var part in body.Skip(1))
            buffer[part.y, part.x] = 'o';

        // Вывод буфера без мерцания
        Console.SetCursorPosition(0, 0);
        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.Gray;
        for (int y = 0; y < 25; y++)
        {
            for (int x = 0; x < 80; x++)
            {
                char ch = buffer[y, x];
                if (ch == 0) ch = ' ';
                Console.ForegroundColor = ch switch
                {
                    'O' => ConsoleColor.Red,
                    '@' => ConsoleColor.Green,
                    'o' => ConsoleColor.Green,
                    '#' => ConsoleColor.DarkGray,
                    _ => ConsoleColor.Gray
                };
                Console.Write(ch);
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }

private static void ShowGameOver()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(32, 10);
        Console.WriteLine("ИГРА ОКОНЧЕНА!");
        Console.SetCursorPosition(34, 12);
        Console.WriteLine($"Очки: {new SnakeGame().score}"); // Показывает финальный score
        Console.ResetColor();
        Console.CursorVisible = true;
        Console.ReadKey(true);
    }
}

class Program
{
    static void Main()
    {
        new SnakeGame().Run();
    }
}