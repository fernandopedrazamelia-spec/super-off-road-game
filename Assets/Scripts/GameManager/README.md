# Game Manager

## Descripción
Gestiona la lógica general de la carrera, puntuación y estado del juego.

## Funcionalidades
- 🏁 Control de vueltas y fin de carrera
- ⏱️ Cronómetro de carrera
- 🏆 Sistema de puntuación
- 👥 Gestión de múltiples corredores
- 🔄 Reinicio de carrera

## Variables Principales
- `lapsToComplete`: Número de vueltas requeridas
- `numberOfAIOpponents`: Cantidad de adversarios IA
- `raceTimeout`: Tiempo máximo de carrera

## Métodos Públicos
```csharp
GameManager.Instance.CompleteLap()        // Registrar vuelta completada
GameManager.Instance.EndRace(bool won)    // Terminar carrera
GameManager.Instance.GetPlayerCurrentLap() // Obtener vuelta actual
GameManager.Instance.GetRaceElapsedTime() // Tiempo transcurrido
```

## Uso
- Singleton automático
- Se persiste entre escenas
- Integrado con UIManager y PlayerData
