# hello
Hello, World! (API)

asp.net core WebAPI with associated console application and tests (xUnit)

#**API**
##boundary - /api/greeting/{name}

##service - **IGreeterService**
Currently using singleton pattern but that will probably switch to scope
or transient in future especially if using database.

##result - **Greeting**
######Message - property
contains greeting message
######Name    - property
