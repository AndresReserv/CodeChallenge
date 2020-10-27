The project was created in 5 layers with .NET core 2.1

1) Front
- Api rest
- MVC
2) Entities
3) Interfaces
4) Business
5) Data Access
- Access to AIP employee.
- To manipulate contract type I use a code first with entity framework core 2.1.14.

I did an unit test project, but I don't use mocks

I added a script database. You can use the migration to create the database, but in the script are the registers of table.
Are only 2 registers.
