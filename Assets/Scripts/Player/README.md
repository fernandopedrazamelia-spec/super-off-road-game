# Player Controller

## Descripción
Sistema de control del coche del jugador con física realista para juegos 2D top-down.

## Características
- ⚙️ Aceleración y frenado progresivo
- 🎮 Controles sensibles a la velocidad
- 🌍 Efectos de terreno dinámicos
- 🔄 Sistema de fricción realista
- 📱 Optimizado para móvil

## Variables Principales
- `acceleration`: Velocidad de aceleración
- `maxSpeed`: Velocidad máxima
- `friction`: Factor de fricción
- `rotationSpeed`: Velocidad de rotación del coche
- `driftFactor`: Factor de drift en curvas

## Terrenos Soportados
- **Mud (Barro)**: 60% velocidad máxima
- **Sand (Arena)**: 70% velocidad máxima
- **Stone (Piedras)**: 90% velocidad máxima
- **Road (Carretera)**: 100% velocidad máxima

## Uso
Adjunta el script a un GameObject con:
- `Rigidbody2D` (Body Type: Dynamic)
- `Collider2D`
- `SpriteRenderer` (sprite del coche)
