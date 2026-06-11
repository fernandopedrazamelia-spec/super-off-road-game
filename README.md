# Super Off Road - Juego de Carreras 2D Móvil

## 📱 Descripción
Juego de carreras 2D estilo Super Off Road de los años 80 para plataformas móviles (iOS/Android). Compite contra 4 adversarios controlados por IA en múltiples pistas con diferentes terrenos.

## 🎮 Características

### Jugabilidad
- ⬅️➡️ **Controles**: Izquierda, Derecha, Acelerar
- 🏁 **Múltiples pistas** con terrenos variados (barro, arena, piedras)
- 🤖 **4 adversarios con IA** inteligente
- 📊 **Sistema de puntos y vueltas**
- 🔧 **Mejoras del coche** (velocidad, agarre, aceleración)
- 📈 **Dificultad media**

### Monetización
- 📺 Sistema de anuncios integrado
- 💳 Compra in-app para eliminar anuncios
- 🎁 Recompensas por partidas

### Estilo Visual
- 🎨 Estilo retro pixel art años 80
- 🌄 Vistas top-down clásico Super Off Road
- 🎵 Música y efectos de sonido vintage

## 🛠️ Stack Tecnológico
- **Motor**: Unity 2022 LTS
- **Lenguaje**: C#
- **Plataformas**: iOS / Android
- **Monetización**: Google Mobile Ads / Unity Ads

## 📁 Estructura del Proyecto
```
super-off-road-game/
├── Assets/
│   ├── Scripts/
│   │   ├── Player/
│   │   ├── AI/
│   │   ├── GameManager/
│   │   ├── UI/
│   │   ├── Terrain/
│   │   └── Utils/
│   ├── Prefabs/
│   ├── Scenes/
│   ├── Sprites/
│   ├── Audio/
│   └── Resources/
├── ProjectSettings/
└── README.md
```

## 🚀 Cómo Compilar y Ejecutar

### Requisitos
- Unity 2022 LTS o superior
- Android SDK / Xcode (para compilación)

### Instalación
1. Clona el repositorio
```bash
git clone https://github.com/fernandopedrazamelia-spec/super-off-road-game.git
```

2. Abre el proyecto en Unity
3. Abre la escena principal: `Assets/Scenes/MainScene.unity`
4. Presiona Play para probar

### Build para Móvil
**Android:**
```
File > Build Settings > Select Android > Build
```

**iOS:**
```
File > Build Settings > Select iOS > Build & Run
```

## 📖 Documentación del Código
- [Scripts de Jugador](./Assets/Scripts/Player/README.md)
- [Sistema de IA](./Assets/Scripts/AI/README.md)
- [GameManager](./Assets/Scripts/GameManager/README.md)

## 🎯 Próximas Mejoras
- [ ] Sistema de tienda mejorado
- [ ] Nuevas pistas
- [ ] Modos de juego adicionales
- [ ] Leaderboards en línea
- [ ] Personalización de coches

## 📄 Licencia
MIT License

## 👤 Autor
Fernando Pedraza Melia

---
**¿Encontraste un bug?** Abre un issue en GitHub 🐛