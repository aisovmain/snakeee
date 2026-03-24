<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Змейка — Как играть</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            max-width: 800px;
            margin: 0 auto;
            padding: 40px 20px;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: #333;
            line-height: 1.6;
        }
        .container {
            background: rgba(255,255,255,0.95);
            border-radius: 20px;
            padding: 40px;
            box-shadow: 0 20px 40px rgba(0,0,0,0.2);
        }
        h1 {
            text-align: center;
            color: #4a5568;
            font-size: 3em;
            margin-bottom: 10px;
            text-shadow: 2px 2px 4px rgba(0,0,0,0.1);
        }
        .subtitle {
            text-align: center;
            color: #718096;
            font-size: 1.2em;
            margin-bottom: 40px;
        }
        .section {
            margin: 30px 0;
            padding: 25px;
            background: #f8f9ff;
            border-radius: 15px;
            border-left: 5px solid #4299e1;
        }
        .section h2 {
            color: #2d3748;
            font-size: 1.8em;
            margin-bottom: 15px;
            display: flex;
            align-items: center;
        }
        .section h2::before {
            content: attr(data-icon);
            font-size: 1.5em;
            margin-right: 15px;
        }
        .controls {
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            gap: 20px;
            margin: 20px 0;
        }
        .control-key {
            background: linear-gradient(45deg, #48bb78, #38a169);
            color: white;
            padding: 20px;
            text-align: center;
            border-radius: 15px;
            font-size: 1.5em;
            font-weight: bold;
            box-shadow: 0 8px 20px rgba(72,187,120,0.3);
            transition: transform 0.2s;
        }
        .control-key:hover {
            transform: translateY(-5px);
        }
        .goal {
            font-size: 1.3em;
            background: linear-gradient(45deg, #ed8936, #dd6b20);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            font-weight: bold;
        }
        .tips {
            background: linear-gradient(135deg, #bee3f8, #90cdf4);
            border-left-color: #4299e1;
        }
        .score-demo {
            background: #2d3748;
            color: #00ff00;
            font-family: 'Courier New', monospace;
            padding: 20px;
            border-radius: 10px;
            font-size: 1.2em;
            margin: 20px 0;
        }
        footer {
            text-align: center;
            margin-top: 40px;
            padding: 20px;
            color: #a0aec0;
            font-style: italic;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>🐍 Змейка</h1>
        <p class="subtitle">Классическая консольная игра без мерцания</p>

        <div class="section">
            <h2 data-icon="⌨️">Управление</h2>
            <div class="controls">
                <div class="control-key">W<br><small>↑ вверх</small></div>
                <div class="control-key">A ← S ↓ D →<br><small>движение</small></div>
                <div class="control-key">ESC<br><small>выход</small></div>
            </div>
        </div>

        <div class="section">
            <h2 data-icon="🎯">Цель игры</h2>
            <p class="goal">Управляй зелёной змейкой (@ — голова, o — тело)</p>
            <ul>
                <li><strong>Ешь красные яблоки "O"</strong> — змейка растёт + очки</li>
                <li><strong>Не врезайся</strong> в границы (#) и в себя!</li>
            </ul>
        </div>

        <div class="section">
            <h2 data-icon="📊">Очки</h2>
            <p>Счётчик в левом верхнем углу: <strong>SCORE: XX</strong></p>
            <div class="score-demo">
#SCORE:05 ################<br>
#     @ ooo O     ########<br>
#                    ######
            </div>
            <p><em>Каждое яблоко = +1 очко</em></p>
        </div>

        <div class="section tips">
            <h2 data-icon="🚀">Советы</h2>
            <ul>
                <li>Меняй направление <strong>только на 90°</strong> (нельзя назад!)</li>
                <li>Ешь яблоки быстро — поле большое!</li>
                <li><strong>Цель:</strong> побить свой рекорд</li>
            </ul>
        </div>

        <div class="section">
            <h2 data-icon="🏁">Начало и конец</h2>
            <ol>
                <li>Запуск → <strong>синий титульник "ЗМЕЙКА"</strong></li>
                <li>Нажми <strong>любую клавишу</strong></li>
                <li>Играй!</li>
                <li><strong>Конец:</strong> "ИГРА ОКОНЧЕНА!" + очки</li>
            </ol>
        </div>

        <footer>
            🐍 Сделано на C# • 85мс • Без мерцания • Наслаждайся!
        </footer>
    </div>
</body>
</html>
