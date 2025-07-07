using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLNotes
{
    internal class Methods
    {

        /*
 
 
 

        Fetch Offset
        fetch offset allows us to fetch a certain part of the result of a search query
        usually used for pagination. we can choose how many rows to skip and 
        how many rows to return.

        Inner Join
        used to combine rows from two or more tables with one common column from both table,
        it returns only the matching rows from both table.
    
        left / right join
        --left
        Returns all rows from the left table (Customers), and matching rows 
        from the right table (Orders). If no match is found, NULLs are returned 
        for the right table columns.
       
        FULL OUTER JOIN
        returns all the rows from both table if the match is not found then null
        are returned

        GROUP BY
        groups the data together based on a specific column along with an aggreate function
        like sum, avg, count
 
        HAVING
        WHERE filters rows before grouping,
        HAVING filters groups after grouping.

        COUNT(), SUM(), AVG() --- NAHH, Bruh!

        WITH
        used to create a temperory mini table with your querries which you can reuse inside a query

        ROW_NUMBER
        returns a row number

        CREATE VIEW
        a virtual table, it doesnt store the data in it self but rather shows the data from 
        the tables underneath

        FOREIGN KEY
        foreign key creates a relation between two tables, a primary key from one table used in
        a child table. 
        Ensures you can’t insert a value in the child table unless it exists in the parent table
        Helps maintain referential integrity

        DEFAULT
        sets a default value for a column if isn't provided

        UNIQUE
        ensures no duplicate record in the column
 

        */
    }
}
