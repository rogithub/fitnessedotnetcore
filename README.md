# Ejemplo de uso de FitNesse
Para este ejemplo uso dotnet core en linux.
Deberá ajustar los paths en caso de usar algo diferente.
En especial note el archivo "division.txt" (explicado más abajo),
que hace referencia a mi "home" directory. /home/ro/.nuget/packages/

## Paso 1. Compilar el dll
```sh
$ cd Ro.Fitnesse.Console/
$ dotnet build
```
## Paso 2. Instalar FitNesse dentro de ./fitnesse
[http://fitnesse.org/FitNesseDownload](http://fitnesse.org/FitNesseDownload)
## Paso 3. Ejecutar el server
```sh
$ cd fitnesse
$ chmod +x startcommand.sh
$ ./startcommand.sh
```
## Paso 4. Ir a http://localhost:8080/Division y pegar el contenido de
[division.txt](https://raw.githubusercontent.com/rogithub/fitnessedotnetcore/master/fitnesse/Division.txt)

## Paso 5. En http://localhost:8080/Division?properties seleccionar radio "type: Test" y dar click en Test

# Fuentes consultadas
- https://fitsharp.github.io/FitSharp/RunTestsWithFitnesse.html
- https://www.stevefenton.co.uk/2013/10/Using-Fitnesse-For-Dot-Net
