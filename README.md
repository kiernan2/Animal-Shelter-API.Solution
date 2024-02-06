# Animal-Shelter-API

#### A program for tracking animals and animal data 

#### By Kiernan Beattie

## Technologies Used

* C#
* Dotnet
* Html
* Entity

## Description

* You can Create animals(cats and dogs)
* Contains places for name age and gender of animals

## Setup/Installation Requirements

1. Open terminal cd to a Appropriate directory enter `git clone https://github.com/kiernan2/Animal-Shelter-API.Solution.git`
2. Enter `dotnet restore`, `dotnet build`, `dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 5.0.0` and `dotnet tool install --global dotnet-ef --version 3.0.0` in `Same directory/Animal-Shelter-API.Solution/AnimalShelterApi`
3. Create a appropriate appsettings.json With a connection string IE
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=YOUR-PASSWORD-HERE;"
  }
}
```
4. Enter `dotnet ef database update` to build the appropriate database
5. Open a terminal and cd to `(Wherever you put the file)/Animal-Shelter-API.Solution/AnimalShelter`
6. Enter dotnet run
7. Open a browser Go to `http://localhost:5000`

## Known Bugs

* N/a

## License

MIT 2023

## Contact Information
Kiernan1994@gmail.com