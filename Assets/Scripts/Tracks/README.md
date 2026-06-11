# Sistema de Circuitos (Track System)

## 📋 Descripción General
Sistema completo de 10 circuitos diferentes con obstáculos dinámicos, checkpoints y terrenos variados.

## 🏁 Los 10 Circuitos

### 1. **Desierto Dorado** (45s)
- Tipo: Arena
- Tamaño: Pequeño
- Obstáculos: Rocas, Cactus
- Secciones: 4

### 2. **Bosque Misterioso** (50s)
- Tipo: Barro
- Tamaño: Pequeño
- Obstáculos: Árboles, Logs, Barro
- Secciones: 7

### 3. **Pico Rocoso** (65s)
- Tipo: Piedra
- Tamaño: Medio
- Obstáculos: Rocas, Peñascos
- Secciones: 8

### 4. **Tormenta Helada** (55s)
- Tipo: Hielo
- Tamaño: Pequeño
- Obstáculos: Hielo, Peñascos
- Secciones: 7

### 5. **Jungla Salvaje** (80s)
- Tipo: Barro
- Tamaño: Grande
- Obstáculos: Árboles, Enredaderas, Logs
- Secciones: 10

### 6. **Volcán Ardiente** (70s)
- Tipo: Piedra
- Tamaño: Medio
- Obstáculos: Peñascos, Lava
- Secciones: 9

### 7. **Cañón Profundo** (52s)
- Tipo: Piedra
- Tamaño: Pequeño
- Obstáculos: Peñascos, Rocas
- Secciones: 7

### 8. **Pantano Tenebroso** (75s)
- Tipo: Barro
- Tamaño: Medio
- Obstáculos: Barro, Agua, Logs
- Secciones: 9

### 9. **Isla Tropical** (85s)
- Tipo: Arena
- Tamaño: Grande
- Obstáculos: Cactus, Arena, Agua
- Secciones: 10

### 10. **Cristales Congelados** (58s)
- Tipo: Hielo
- Tamaño: Pequeño
- Obstáculos: Hielo, Peñascos
- Secciones: 8

## 🔧 Componentes Principales

### TrackManager.cs
Gestor central de circuitos:
- Carga y descarga de pistas
- Generación de obstáculos
- Gestión de checkpoints
- Selección de circuitos

### Checkpoint.cs
Sistema de puntos de control:
- Detección de paso por checkpoint
- Validación de orden correcto
- Detección de línea de meta
- Contador de vueltas

### Obstacle.cs
Sistema de obstáculos:
- Diferentes tipos de obstáculos
- Colisión con jugador
- Efectos específicos por tipo
- Desaceleración dinámica

### TrackUI.cs
Interfaz de selección de circuitos:
- Pantalla de selección
- Información del circuito
- Botones para elegir pista

## 📊 Tipos de Obstáculos

| Obstáculo | Efecto | Circuitos |
|-----------|--------|----------|
| Rock | Desaceleración | Todos |
| Boulder | Desaceleración fuerte | Montaña, Volcán |
| Tree | Colisión/Desaceleración | Bosque, Jungla |
| Cactus | Daño + Desaceleración | Desierto, Isla |
| Log | Obstáculo físico | Bosque, Jungla, Pantano |
| Mud | Zona de fango | Bosque, Jungla, Pantano |
| Sand | Dificultad en aceleración | Desierto, Isla |
| Water | Desaceleración severa | Pantano, Isla |
| Ice | Resbaladizo | Nieve, Cristales |
| Vines | Obstáculo de enredaderas | Jungla |
| Lava | Daño crítico | Volcán |

## 🎮 Cómo Usar

### Cargar un circuito:
```csharp
TrackManager.Instance.LoadTrack(0); // Carga Desierto Dorado
```

### Obtener información del circuito actual:
```csharp
TrackData currentTrack = TrackManager.Instance.GetCurrentTrack();
Debug.Log($\"Circuito: {currentTrack.trackName}\");
```

### Listar todos los circuitos:
```csharp
TrackData[] allTracks = TrackManager.Instance.GetAllTracks();
for (int i = 0; i < allTracks.Length; i++)
{
    Debug.Log($\"{i}: {allTracks[i].trackName}\");
}
```

## 🚀 Características

✅ 10 circuitos únicos con diferentes dificultades
✅ Obstáculos generados aleatoriamente
✅ 11 tipos de obstáculos diferentes
✅ Sistema de checkpoints automático
✅ Terrenos variados (Barro, Arena, Piedra, Hielo)
✅ Tamaños de pista diferentes (Pequeño, Medio, Grande)
✅ Tiempos de vuelta estimados
✅ Efectos específicos por tipo de obstáculo
✅ Sistema de colisión dinámico

## 📈 Expansión Futura

- [ ] Editor de circuitos visual
- [ ] Circuitos generados proceduralmente
- [ ] Circuitos nocturnos
- [ ] Lluvia y efectos climáticos
- [ ] Circuitos con varias dificultades
- [ ] Modo editor custom
- [ ] Circuitos multijugador
