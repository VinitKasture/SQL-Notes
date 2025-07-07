using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLNotes
{
    public class DataTypes
    {
        /*
         
        CHAR
        Char stores no of characters as per the length, if less characters are stored than
        the length specified then the rest of the space is filled with spaces

        Use CHAR when: All entries are the same length
        
        it stores CHAR as fixed-length, so it knows exactly how much space each value takes 
        even on disk and in memory. That makes certain operations faster.


        VARCHAR
        It stores text strings with variable length

        BINARY
        it stores the data in bytes (binary data) rather than human readable text

        VARBINARY
        It is used to store raw binary data like images, files, encrypted values, 
        or any custom byte data — but unlike BINARY, it only uses as much space as needed.

        BIT
        The BIT data type is used to store Boolean-like values — essentially, 0 (false) or 1 (true)
        stores 1 if provided value greater than 1 as true

        TINYINT
        Only stores positive values

        SMALLINT, INT, BIGINT
        Can store both negative and positive values
        {tinyint, smallint, int - each one have a different range}

        FLOAT
        A floating-point numeric data type used to store approximate numerical 
        values with floating decimal points.

        FLOAT and REAL store numbers using binary floating-point representation, not exact decimal.
        This method trades accuracy for range and performance.
        Because some decimal numbers can’t be represented exactly in binary, 
        the value stored is very close, but not always exactly the same as what you input.
         
        DECIMAL
        A fixed precision and scale numeric data type used to store exact 
        numeric values with defined digits before and after the decimal point.

        REAL
        A floating-point numeric data type that stores approximate numeric values
        with less precision than FLOAT.
        
        DATE
        Only the date (year, month, day)

        DATETIME
        Both date and time

        DATETIME2
        Date and time (like DATETIME) but with more precision and a larger range

        TIME
        Only the time part, no date

         

         */
    }
}
