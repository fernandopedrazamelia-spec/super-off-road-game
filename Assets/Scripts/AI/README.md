# AI Controller

## Descripción
Sistema de IA para controlar los coches adversarios con navegación inteligente.

## Características
- 🤖 Pathfinding automático
- 🚗 Evasión de obstáculos
- ⚡ Tres niveles de dificultad
- 🎯 Toma de decisiones reactiva

## Niveles de Dificultad
- **Easy (0.8)**: 80% de velocidad máxima
- **Medium (1.0)**: 100% de velocidad máxima
- **Hard (1.2)**: 120% de velocidad máxima

## Parámetros Configurables
- `pathfindingDistance`: Distancia de detección de obstáculos
- `reactionTime`: Tiempo entre decisiones de IA
- `difficulty`: Multiplicador de dificultad

## Uso
Adjunta el script a un GameObject con:
- `Rigidbody2D` (Body Type: Dynamic)
- `Collider2D`
- Tag "AIRacer"
