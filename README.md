# C-Music-Manager-App

This project is still currently under construction.


The main purpose of this application is to allow a user to manage music data in a T-SQL database. There are 3 entities in the application: Albums, Artists, and Songs. The Artist entity has a many to many relation with the other entities. There is a page to display individual information about each entity as well as pages for displaying lists of all entities of a specific type. Validation is present in some areas but not all.

The application consists of a main page with a DGV where the user can see a full list of each of the entities. The DGV supports sorting. From there the user can click a set of 3 different buttons to add an entity of each type. Each entity in the DGV has a series of buttons that allow you perform a few different actions on that entity. Depending on the action, a new form will be displayed relating to that action.

The database in this project was created through database first driven development using Entity Framework to scaffold the entity classes. The database consists of 5 tables. 3 of which are for the entities and the other two that keep track of the relationships between the artists and the other entities. 

Technologies and lanugages used in this application include C#, .Net Winforms, Entity Framework Core, and T-SQL. 
