# ASP.NET Core Web API Week 3 Assignment 1 - HTTP Requests

## Course: Back-End-Web-Development
## Instructor: Christine Bittle

## Overview

This project implements a series of ASP.NET Core Web API endpoints to perform different tasks based on the provided assignment specifications. The assignment includes several endpoints for returning a welcome message, greeting users, performing mathematical calculations, and handling online store orders.

The API has been implemented with C# and is structured to be easy to understand and use. The source code files are located in the `Controllers` folder, with each question's logic implemented in its respective controller.

## Project Structure

The project follows the ASP.NET Core Web API structure. All the endpoints are defined in controllers, which are located in the Controllers folder.

### Controllers

- WelcomeController.cs: Handles the welcome endpoint.

- GreetingController.cs: Handles the greeting endpoint.

- CubeController.cs: Handles the cube calculation.

- KnockKnockController.cs: Handles the knock-knock joke.

- SecretController.cs: Handles the secret acknowledgment.

- HexagonController.cs: Handles the hexagon area calculation.

- TimeMachineController.cs: Handles the date time machine.

- SquashFellowsController.cs: Handles the SquashFellows order processing.

## How to run the project

### Requirements:

- .NET SDK 6.0 or later

- Visual Studio 2022 or Visual Studio Code (VS Code)

### Steps to Run:

1. Clone the repository or download the project `https://github.com/awsactivators/week3-a1-http-request.git`.

2. Open the project in Visual Studio or VS Code.

3. Restore the dependencies.

```c#
dotnet restore
```

4. Run the project

```c#
dotnet run
```
5. The API will be running at `http://localhost:5000` or `https://localhost:5001` or any port that is given to you (mine is 5169).


## Endpoints

1. **GET** /api/q1/welcome

Description: Returns a welcome message.

Example: GET http://localhost:5169/api/Welcome/welcome

Response: "Welcome to 5125!"

2. **GET** /api/q2/greeting?name={name}

Description: Returns a greeting message for the specified name.

Example: GET http://localhost:5169/api/Greeting/greeting?name=Gary

Response: "Hi Gary!"

3. **GET** /api/Cube/cube/{base}

Description: Returns the cube of the specified base integer.

Example: GET http://localhost:5169/api/Cube/cube/4

Response: 64

4. **POST** /api/KnockKnock/knockknock

Description: Returns the start of a knock-knock joke.

Example: POST http://localhost:5169/api/KnockKnock/knockknock

Response: "Who's there?"

5. **POST** /api/Secret/secret

Description: Acknowledges a secret integer.

Example:

```c#
curl -H "Content-Type: application/json" -d "5" https://localhost:5169/api/Secret/secret
```

6. **GET** /api/Hexagon/hexagon?side={S}

Description: Returns the area of a regular hexagon with side length S.

Example: GET http://localhost:5169/api/Hexagon/hexagon?side=1

Response: 2.598076211353316

7. **GET** /api/TimeMachine/timemachine?days={days}

Description: Returns the date adjusted by the specified number of days.

Example: GET http://localhost:5169/api/TimeMachine/timemachine?days=1

Response: "2024-09-23"

8. **POST** /api/SquashFellows/squashfellows

Description: Processes an order for SquashFellows plushies (small and large sizes).

Input Format: application/x-www-form-urlencoded

Parameters:

small: Number of small plushies.

large: Number of large plushies.

Example:

```c#
curl -X POST -d "small=1&large=1" http://localhost:5169/api/SquashFellows/squashfellows
```

Response:

1 Small @ $25.50 = $25.50; 1 Large @ $45.50 = $45.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58

## Testing

You can test the API using cURL, swagger UI or any other HTTP client.

For example, to test the SquashFellows order, you can use the following cURL command on your terminal:

```c#
curl -X POST -d "small=2&large=1" http://localhost:5000/api/SquashFellows/squashfellows
```

To test with swagger UI

Go to `http://localhost:5169/swagger/index.html`

## Additional notes

- The C# files that implement the controllers and logic for the endpoints are located in the Controllers folder.

- Ensure that HTTPS is enabled in the project settings if you're accessing the endpoints via HTTPS.

## Tech Stack

- ASP.NET Core Web API: Framework used to build the API.

- C#: Programming language used for implementing the API.

- .NET Core SDK: Runtime environment for executing the API.

- Visual Studio Code (Vscode): Code editor used for writing, debugging, and managing the project files. 

