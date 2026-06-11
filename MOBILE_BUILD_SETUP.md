# 📱 Setup de Build para Móvil - Super Off Road

## Requisitos Previos

### Android:
- Android SDK (API Level 28+)
- Android NDK
- Java Development Kit (JDK)

### iOS:
- Xcode 12+
- Apple Developer Account

---

## ⚙️ Player Settings (Android)

**Edit > Project Settings > Player > Android**

```
Company Name: SuperOffRoad
Product Name: Super Off Road
Package Name: com.superoffroad.game
Version: 1.0.0
Bundle Version Code: 1
```

**Orientación:**
- Default Orientation: Portrait
- Allowed Orientations: Portrait

**API Levels:**
- Minimum API Level: Android 7.0 (API 24)
- Target API Level: Android 14 (API 34)

**Graphics:**
- Graphics APIs: OpenGLES3, Vulkan
- Use 32-bit Display Buffer: ON

---

## 🍎 Player Settings (iOS)

**Edit > Project Settings > Player > iOS**

```
Bundle Identifier: com.superoffroad.game
Version: 1.0
Build: 1
Target Minimum iOS Version: 13.0
```

---

## 📦 Dependencias Requeridas

1. **Google Mobile Ads SDK**
2. **Unity IAP (In-App Purchasing)**
3. **TextMesh Pro**

En **Assets > External Dependency Manager > Android Resolver > Force Resolve**

---

## 🔐 Keystore para Android (Firma)

Generar keystore:
```bash
keytool -genkey -v -keystore superoffroad.keystore -keyalg RSA -keysize 2048 -validity 10000 -alias superoffroad
```

En Unity:
- Edit > Project Settings > Player > Android > Publish Settings
- Cargar keystore y contraseña

---

## 🎮 Build APK

```
File > Build Settings
- Select Android
- Click "Build"
- Guardar como: super-off-road.apk
```

**Testing en dispositivo:**
```bash
adb install super-off-road.apk
```

---

## 📱 Build AAB (Play Store)

```
File > Build Settings
- Select Android
- Click "Build"
- Generar AAB en lugar de APK
- Subir a Google Play Console
```

---

## 🍎 Build para iOS

```
File > Build Settings
- Select iOS
- Click "Build"
- Abrir proyecto Xcode generado
- En Xcode:
  - Select Team
  - Product > Archive
  - Subir a App Store
```

---

## 🚀 Optimizaciones Principales

✅ Frame Rate: 60 FPS (ajustable)
✅ Calidad gráfica: Adaptativa
✅ Modo bajo consumo: Disponible
✅ Input táctil: Optimizado
✅ Memoria: Gestión automática

---

## ✅ Checklist Final

- [ ] Package name configurado
- [ ] Versión correcta
- [ ] Iconos de app (192x192, etc.)
- [ ] Splash screen
- [ ] Ad Unit IDs configurados
- [ ] IAP products configurados
- [ ] Política de privacidad
- [ ] Permisos: INTERNET, ACCESS_NETWORK_STATE
- [ ] Probado en dispositivo real
- [ ] Certificados actualizados

---

**¡Listo para compilar!** 🎮
