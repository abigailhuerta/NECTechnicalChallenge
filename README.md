# NEC Technical Challenge

El proyecto se realizó utilizando  Clean Architecture  con el propósito de generar una separación de responsabilidades, un mejor control en el manejo de errores y principalmente  preparar a la aplicación para que pueda ser  escalable  y  consumida por uno o más clientes, los cuales pueden ser Web, Blazor, Angular, Xamarin, etc.

# Web API
El proyecto NEC.Crypto.Api  es una Web API la cual expone los endpoint : api/cryptos y api/conversioncrypto y puede ser consumida  por diferentes clientes que hagan uso del protocolo Http

En este proyecto encontraremos el archivo appsettings.json en el cual podremos configurar algunos parámetros como es el API Key del servicio [Coin Market Cap](https://coinmarketcap.com/api/documentation/v1/)

# Cliente Blazor WebAssembly
La aplicación Cliente está realizada en Blazor Web Assembly la cual nos permite crear una Sigle Page Application que consume a la Web APINEC.Crypto.Api 


### Patrones : 
 - Mediator
 - CQRS
 - Inversion de Dependecias
 - Inyección de dependencia
 - Presentadores
 
### Principios
 - Inversion de Control
 - SOLID
 
### Frameworks
  - .NET6
  - .ASP.NET Core Web API con .NET6
  

Colocar el proyecto NEC.Crypto.Api ubicado en la carpeta Frameworks And Drivers como proyecto de Inicio.
  
  
  
