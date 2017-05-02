# EntityFramework Migration Commands

wlaczenie migracji:
Enable-Migrations
	
dodanie jednostkowej migracji (roznicy modelu z baza)
Add-Migration AddStart

zastosowanie migracji na bazie
Update-Database –TargetMigration: AddStart
 
powrot do stanu 0
Update-Database –TargetMigration: $InitialDatabase
 
wygenerowanie skryptu roznicowego
Update-Database -Script

## Scenario - Code First Migration

1. Create model
    ```csharp
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public int PageCount { get; set; }
        public string ISBN { get; set; }
    }
    ```

2. Enable migrations via Package Manager Console
    ```
    Enable-Migrations
    Add-Migration AddStart
    Update-Database
    ```

3. Modify model
    ```csharp
    public class Book
    {
        ...
        public int PageCount { get; set; }
        ...
    ```

    in PMC

    ```
    Add-Migration AddBookPageCount
    Update-Databse
    ```