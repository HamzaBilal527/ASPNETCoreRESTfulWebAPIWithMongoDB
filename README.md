Run MongoDb Server at the default port: mongodb://localhost:27017

Create a database with name: "CustomerDatabase"

Create a collection with name: "Customers"

Download, Extract and Run the Solution in the Visual Studio.

Open PostMan and Send following Requests Separately to see the results:

POST: http://localhost:5167/api/home Body: {"CustomerId" : 1, "Name" : "Micheal", "Age": 34, "Salary": 2300} | {"CustomerId" : 2, "Name" : "Sally", "Age": 29, "Salary": 1300}

GET: http://localhost:5167/api/home (For All Customers)

GET: http://localhost:5167/api/home/2 (For a Single Customer)

PUT: http://localhost:5167/api/home Body: {"CustomerId" : 2, "Name" : "Sally", "Age": 66, "Salary": 5500} (For Updating Age and Salary)

DEL: http://localhost:5167/api/home/2 (For Deleting Customer)
