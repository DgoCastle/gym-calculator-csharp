# 💪 Gym Calculator (C# WinForms)

Aplicación de escritorio en **C# (.NET Framework 4.8, WinForms)**, con interfaz moderna usando **Guna UI2** y **FontAwesome.Sharp**. Proyecto escolar (noviembre 2025).

## ✨ Funciones
- **Calculadora de 1RM (repetición máxima):** estima tu máximo a partir del peso y las repeticiones con la fórmula de Epley: `1RM = peso × (1 + 0.0333 × reps)`.
- **Calculadora de física del levantamiento:** con la carga, la distancia, la inclinación y el tiempo calcula la **fuerza**, la **fuerza efectiva**, el **trabajo (W)** y la **potencia**.
- **Navegación con user controls:** un panel principal que cambia de vista sin abrir ventanas nuevas.

## 📋 Ingeniería de requerimientos
El proyecto empezó con un documento de requerimientos: requerimientos funcionales y no funcionales, actores, entradas y salidas, criterios de aceptación y casos de verificación (por ejemplo, 100 kg × 10 reps → 1RM = 133.3 kg). Está en [`docs/requerimientos.pdf`](docs/requerimientos.pdf).

## 🚀 Cómo correrlo
1. Abre `Castillo_Diego_S13T1.sln` en **Visual Studio**.
2. Restaura los paquetes NuGet (clic derecho en la solución → *Restore NuGet Packages*).
3. Ejecuta con **F5**.

## 🛠️ Tecnologías
C# · .NET Framework 4.8 · Windows Forms · Guna.UI2.WinForms · FontAwesome.Sharp
