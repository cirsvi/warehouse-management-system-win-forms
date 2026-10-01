# Warehouse Management System

## Entity Relationship Diagramm (ERD)
![Enrity Relationship Diagramm](./screenshots/enitity-relationship-diagramm.png)

> [!NOTE]
> The relationships for the **audit attributes** (`createdByID` and `alteredByID`) are not displayed to avoid visual clutter. Each `createdByID` and `alteredByID` is a FK connected to the `Users.userID` field.

## Project Structure
```
.
├── database-scrips         # sql scripts for tables and sample data
├── screenshots             # images used in README
└── README.md       
```