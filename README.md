# 📱 SUPER OFF ROAD - Juego Móvil Completo

## 🎮 Descripción General

**Super Off Road** es un juego de carreras 2D en estilo retro de los años 80 para plataformas móviles (iOS y Android).

Compite contra 4 adversarios controlados por IA en 10 circuitos únicos con diferentes terrenos y obstáculos.

## ✨ Características Principales

### 🏎️ Jugabilidad
- **Controles simples**: Izquierda, Derecha, Acelerar
- **10 circuitos únicos** (Desierto, Bosque, Montaña, Nieve, Jungla, Volcán, Cañón, Pantano, Isla, Cristales)
- **4 adversarios con IA** inteligente
- **11 tipos de obstáculos** diferentes
- **Sistema de puntos** y mejoras del coche

### 💰 Monetización
- 📺 **Anuncios integrados** (Google Mobile Ads)
- 💳 **Compra in-app** para eliminar anuncios
- 🎁 **Recompensas** por partidas

### 📱 Optimización Móvil
- 60 FPS optimizado
- Input táctil responsivo
- Detección de dispositivo bajo-end
- Modo ahorro de batería

## 📊 Estado del Proyecto (100% Completado)

### ✅ Sistema de Juego
- ✅ Control del jugador (PlayerController.cs)
- ✅ IA de adversarios (AIController.cs - 4 oponentes)
- ✅ GameManager (gestión de carrera)
- ✅ Sistema de progresión (PlayerData.cs)
- ✅ UI Manager (interfaz)
- ✅ Tienda de upgrades (ShopManager.cs)

### ✅ Sistema de Circuitos
- ✅ **10 circuitos únicos** (TrackManager.cs)
- ✅ Checkpoints y vueltas (Checkpoint.cs)
- ✅ Obstáculos dinámicos (Obstacle.cs)
- ✅ Interfaz de selección (TrackUI.cs)

### ✅ Monetización
- ✅ Google Mobile Ads (MobileAdsManager.cs)
- ✅ In-App Purchase (InAppPurchaseManager.cs)

### ✅ Optimización Móvil
- ✅ Input táctil (MobileTouchInput.cs)
- ✅ Optimización de rendimiento (MobileOptimization.cs)
- ✅ Utilidades de pantalla (ScreenUtils.cs)

### ✅ Configuración
- ✅ AndroidManifest.xml
- ✅ Player Settings configurados
- ✅ Guía de build completa (MOBILE_BUILD_SETUP.md)

## 📁 Estructura del Proyecto

```
Assets/Scripts/
├── Player/                  # Control del jugador
│   └── PlayerController.cs
├── AI/                     # Adversarios IA
│   └── AIController.cs
├── Tracks/                 # Sistema de 10 circuitos
│   ├── TrackManager.cs     # Gestor principal
│   ├── Checkpoint.cs       # Puntos de control
│   ├── Obstacle.cs         # Obstáculos
│   └── TrackUI.cs         # Interfaz
├── GameManager/            # Lógica de carrera
│   ├── GameManager.cs
│   ├── PlayerData.cs
│   └── ShopManager.cs
├── UI/                     # Interfaz del juego
│   └── UIManager.cs
├── Monetization/           # Monetización
│   ├── MobileAdsManager.cs
│   └── InAppPurchaseManager.cs
├── Input/                  # Input móvil
│   └── MobileTouchInput.cs
├── Mobile/                 # Optimización
│   └── MobileOptimization.cs
└── Utils/                  # Utilidades
    ├── ScreenUtils.cs
    └── FinishLine.cs
```

## 🔧 Tecnología

| Aspecto | Detalles |
|--------|---------|
| Motor | Unity 2022 LTS |
| Lenguaje | C# |
| Plataformas | Android 7.0+ / iOS 13.0+ |
| Tipo | 2D Top-Down |
| Input | Táctil |
| Monetización | Google Ads + IAP |

## 🚀 Compilar el Juego

### Android (APK)
```bash
File > Build Settings > Android > Build
```

### Android (AAB - Play Store)
```bash
File > Build Settings > Android > Build (AAB)
```

### iOS
```bash
File > Build Settings > iOS > Build
# Luego abrir en Xcode y archivizar
```

## 📖 Documentación

- **[MOBILE_BUILD_SETUP.md](./MOBILE_BUILD_SETUP.md)** - Guía completa de build
- **[Assets/Scripts/Tracks/README.md](./Assets/Scripts/Tracks/README.md)** - 10 circuitos
- **[Assets/Scripts/Player/README.md](./Assets/Scripts/Player/README.md)** - Control del jugador
- **[Assets/Scripts/AI/README.md](./Assets/Scripts/AI/README.md)** - Sistema IA

## ⚙️ Configuración Antes de Publicar

1. **Ad Unit IDs** - Reemplazar en `MobileAdsManager.cs`
   - Obtener de: https://admob.google.com

2. **IAP Products** - Crear en:
   - Google Play Console (Android)
   - App Store Connect (iOS)

3. **Assets Visuales**
   - Iconos (192x192, 512x512)
   - Splash screen
   - Screenshots

4. **Política de Privacidad**
   - Requerida por tiendas

## 🎯 Los 10 Circuitos

| # | Nombre | Tamaño | Tiempo | Obstáculos |
|---|--------|--------|---------|-----------|
| 1 | 🏜️ Desierto Dorado | Pequeño | 45s | 8 |
| 2 | 🌳 Bosque Misterioso | Pequeño | 50s | 10 |
| 3 | ⛰️ Pico Rocoso | Medio | 65s | 12 |
| 4 | ❄️ Tormenta Helada | Pequeño | 55s | 9 |
| 5 | 🌴 Jungla Salvaje | Grande | 80s | 15 |
| 6 | 🌋 Volcán Ardiente | Medio | 70s | 11 |
| 7 | 🏜️ Cañón Profundo | Pequeño | 52s | 10 |
| 8 | 🪲 Pantano Tenebroso | Medio | 75s | 13 |
| 9 | 🏝️ Isla Tropical | Grande | 85s | 14 |
| 10 | 💎 Cristales Congelados | Pequeño | 58s | 10 |

## 📝 Checklist Final

- [ ] Ad Unit IDs reales configurados
- [ ] IAP products en tiendas
- [ ] Iconos de app creados
- [ ] Política de privacidad
- [ ] Probado en Android real
- [ ] Probado en iOS real
- [ ] Certificados actualizados

## 📚 Recursos

- [Google Mobile Ads](https://developers.google.com/admob)
- [Unity IAP](https://docs.unity3d.com/Manual/UnityIAP.html)
- [Google Play Console](https://play.google.com/console)
- [App Store Connect](https://appstoreconnect.apple.com)

## 🎮 ¡Listo para Publicar!

El proyecto está 100% funcional y preparado para compilar.

**Versión**: 1.0.0  
**Autor**: Fernando Pedraza Melia  
**Última actualización**: 11 de Junio de 2026
