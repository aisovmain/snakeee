# 🐍 Змейка — Консольная C# игра **без мерцания**

[![Actions Status](https://github.com/YOUR_USERNAME/SnakeCsharp/workflows/Build/badge.svg)](https://github.com/YOUR_USERNAME/SnakeCsharp/actions)
[![.NET](https://github.com/YOUR_USERNAME/SnakeCsharp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/YOUR_USERNAME/SnakeCsharp/actions/workflows/dotnet.yml)

**Классическая "Змейка"** в терминале с **буфером экрана** (0 мерцания), **85мс** FPS, **русским титульником** и очками SCORE.

![Демо](https://via.placeholder.com/800x400/0f0f0f/00ff00?text=%23SCORE%3A12+%40ooo+O+%23%23%23)

## ✨ Что внутри

| Фича | ✅ |
|------|----|
| **Буфер экрана** `char[25,80]` | Без `Console.Clear()` |
| **85мс** тики | Плавная анимация |
| **ASCII "ЗМЕЙКА"** | Русский титульник |
| **SCORE: XX** | Очки в реальном времени |
| **W/A/S/D + ESC** | Интуитивное управление |
| **Границы #** | Чёткие рамки поля |

## 🎮 Быстрый старт (30 сек)

```bash
# Скачай
curl -O https://raw.githubusercontent.com/YOUR_USERNAME/SnakeCsharp/main/Snake.cs

# Компилируй (.NET 6+)
csc Snake.cs

# Играй!
./Snake.exe
