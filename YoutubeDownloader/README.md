# Proyecto: Herramienta de Extracci�n de Audio de Videos de YouTube

Este proyecto es una aplicaci�n de consola desarrollada en C# que utiliza las bibliotecas YouTubeExplode y NAudio para extraer la pista de audio de videos de YouTube y guardarla en formato MP3 en el sistema local.

## Descripci�n

La herramienta permite a los usuarios especificar la URL de un video de YouTube y seleccionar una ubicaci�n de destino para guardar el archivo de audio extra�do. Utiliza YouTubeExplode para obtener informaci�n sobre el video y descargar los datos de audio, y NAudio para convertir los datos de audio en formato MP3.

## Funcionalidades

- Descarga la pista de audio de un video de YouTube.
- Convierte la pista de audio descargada a formato MP3.
- Permite al usuario especificar la ubicaci�n de destino para guardar el archivo MP3.

## Tecnolog�as Utilizadas

- **C#**: Lenguaje de programaci�n utilizado para desarrollar la aplicaci�n.
- **YouTubeExplode**: Biblioteca para interactuar con la API de YouTube y obtener informaci�n sobre videos.
- **NAudio**: Biblioteca para el manejo de audio en .NET, utilizada para convertir el audio descargado a formato MP3.

## Requisitos del Sistema

- **Plataforma**: Windows, macOS, Linux (requiere instalaci�n de .NET Core).
- **Requisitos de Software**: .NET Core 3.1 o superior.

## Instrucciones de Uso

1. Descarga o clona el repositorio desde [URL del Repositorio].
2. Abre el proyecto en tu entorno de desarrollo preferido.
3. Instala los paquetes NuGet necesarios para YouTubeExplode y NAudio.
4. Compila y ejecuta la aplicaci�n.
5. Sigue las instrucciones en la consola para ingresar la URL del video de YouTube y seleccionar la ubicaci�n de destino para el archivo MP3.

## Ejemplo de Uso

```bash
dotnet run
