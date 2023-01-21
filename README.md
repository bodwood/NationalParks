# Travel Api

#### By Bodie Wood

## Technologies Used

- C#
- .NET 6
- ASP.NET Core MVC
- EF Core 6
- SQL
- Entity
- MySQL
- Swagger

## Description
This is an API that includes various National Parks and their attributes. National Parks can searched, deleted, and edited. Users can also register as a user with a username and password, and login with the matching user criteria. Registering as a user and logging in is not a requirement to use this API. 


## Setup/Installation Requirements

* Clone repository to your desktop:
  1. GIT must be installed to clone repository. If GIT is needed, click here: [Install Git](https://docs.github.com/en/get-started/quickstart/set-up-git)
  2. Once GIT is installed, open your terminal and navigate to the desired landing folder
  3. In the terminal run:
    - ```git clone https://github.com/bodwood/NationalParks.git ```
    - ```cd NationalParks```
* Install .NET 6 SDK. If .NET 6 SDK is needed, click here: [Install .NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* Install necessary packages for EF Core and a tool to database updates:
    - ```dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0```
    - ```dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0```
    - ```dotnet tool install --global dotnet-ef --version 6.0.1```
    - ```dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0```
    - ```dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0```
* Create .gitignore file:
  - ```touch .gitignore```
  - ```echo "*/obj/ */bin/ */appsettings.json" > .gitignore ```

* Create a new file called ```appsettings.json``` within the NationalParks directory by running the following:
  - ```cd NationalParks```
  - ```touch appsettings.json```
  - ```
    echo '{
      "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-HERE];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
          }
          }' > appsettings.json
    ```
* _Make sure to set uid and pwd_

* Update Database by running the following:
  - ```dotnet ef database update --project NationalParks```

* Install dependencies:
  - ```npm install```

* Build project:
  - ```dotnet build NationalParks/```

* Run project:
  - ```dotnet run --project NationalParks/```

- Navigate to [https://localhost:5001](https://localhost:5001) to try application

<br>

# Api Documentation
## __Endpoints__

## Registration and Login
```
 POST https://localhost:5001/api/Auth/register
 POST https://localhost:5001/api/Auth/login
 ```

## For POST https://localhost:5001/api/Auth/register

Parameter   | Type  | Required | Description | 
|:---------|:---------:|:---------:|:---------|
username | string | Required | Sets and stores username for user
password | string | Required | Sets and creates hashed password for user

<br>

#### __POST Requests for registration are in JSON format and require username and password.__
Example:

```POST https://localhost:5001/api/Auth/register```
```
    {
        "username" : "user1234",
        "password" : "pass1234"
    }
```

<br>

## For POST https://localhost:5001/api/Auth/login

Parameter   | Type  | Required | Description | 
|:---------|:---------:|:---------:|:---------|
username | string | Required | Retrieves username if one exists and returns error if not
password | string | Required | Retrieves password if one exists and returns error if not
<br>

#### __POST Requests for login are in JSON format and require username and password.__
Example:

```POST https://localhost:5001/api/Auth/login```
```
    {
        "username" : "user1234",
        "password" : "pass1234"
    }
```
<br>

#### _Note_
It is not required to be registered or logged in to use API

<br>
<br>


# Parks
```
 GET https://localhost:5001/Parks
 GET https://localhost:5001/Parks/{id}
 POST https://localhost:5001/Parks
 PUT https://localhost:5001/Parks/{id}
 DELETE https://localhost:5001/Parks/{id}
```

#### _Note_ 
* The {id} value in the URL is a **variable** and should be replaced with the id of the park when using PUT or DELETE
* ```GET http://localhost:5000/Parks``` Returns all parks
* ```GET http://localhost:5000/Parks/{id}``` Returns individual park (depending on id)

<br>

## __Queries__

### For GET https://localhost:5001/Parks

Parameter   | Type  | Required | Description | 
|:---------|:---------:|:---------:|:---------|
ParkName | string | Not Required | Returns parks with matching ParkName value
Region | string | Not Required | Returns parks with matching Region value
StateName | string | Not Required | Returns parks with matching StateName value
Rating | int | Not Required | Returns parks with matching Rating value
SortRating | bool | Not Required | Sorts parks based on rating, in descending order
Random | bool | Not Required | Returns a random park

<br>


#### __Example Queries__
Query to return list of all National Parks:

```GET https://localhost:5001/Parks/```

Query to return park with specified park name, indicated with the value of "Zion":

```GET https://localhost:5001/Parks?parkName=Zion```

Query to return all parks within a specified region, indicated with the value of "Mountain":

```GET https://localhost:5001/Parks?region=Mountain```

Query to return National Parks given a state name, seen below with value of "Utah":

```GET https://localhost:5001/Parks?stateName=Utah```

Query to return National Parks given a rating, seen below with value of "4":

```GET https://localhost:5001/Parks?rating=4```

Multiple query strings can be executed as well, by separating them with an &:

```GET https://localhost:5001/Parks?region=Mountain&rating=4```


<br>
<br>

### __Endpoints that require body input__
##### __POST Requests are in JSON format and require parkName, region, stateName, and rating.__
Example:

```POST https://localhost:5001/Parks```
```
    {
        "parkName": "Yellowstone",
        "region": "Mountain",
        "stateName": "Wyoming",
        "rating" : 4
    }
```
<br>

#### __PUT Requests require a body in JSON format that includes all fields.__
Example:

```PUT https://localhost:5001/Parks/{id}```
```
    {
        "parkId": 5,
        "parkName": "Yellowstone",
        "region": "Mountain",
        "stateName": "Wyoming",
        "rating" : 4
    }
```
<br>

## Known Bugs

* _No known bugs_

<br>

## License

**MIT License**

Copyright (c) 2023 Bodie Wood

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.