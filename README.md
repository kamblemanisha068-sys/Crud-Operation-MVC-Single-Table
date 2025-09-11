# Crud-Operation-MVC-Single-Table
MVC stands for Model – View – Controller.
It is a design pattern used in ASP.NET (and many other frameworks) for separating concerns in a web application.

Model:
Represents the data and business logic of the application.
Communicates with the database.
Example: A Student class with properties like Id, Name, Age.

View:
Handles the UI (User Interface).
Displays data to the user and collects input.
Example: An HTML page showing a list of students.

Controller:
Acts as a bridge between Model and View.
Handles requests, processes user input, and decides which View to render.
Example: StudentController containing actions like Index(), Create(), Edit(), etc.

2. CRUD Operations Theory

CRUD stands for:
Create → Add new data (Insert).
Read → Retrieve and display data.
Update → Edit and save existing data.
Delete → Remove data from the database.

These are the basic operations that every application needs to manage data.

3. How CRUD works in MVC

Here’s the flow for each operation:

a. Create (Insert Data):
View: A form is shown to the user to enter details.
Controller: Accepts form input, validates it, and sends it to the Model.
Model: Saves the data in the database.
View: Redirects to a success page or shows updated list.

b. Read (Retrieve Data):
Controller: Calls the Model to get data.
Model: Fetches data from the database.
View: Displays the data (like a list of students).

c. Update (Edit Data):
Controller: Loads existing data from Model and sends it to the View.
View: Displays the data in an editable form.
Controller: Accepts updated input and sends it to Model.
Model: Updates the database record.

d. Delete (Remove Data):
Controller: Requests Model to delete a record by ID.
Model: Removes the record from the database.
View: Shows updated list without deleted record.

Model: Removes the record from the database.

View: Shows updated list without deleted record.
