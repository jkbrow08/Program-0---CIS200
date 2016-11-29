// Assignment: Program 0
// Class:     CIS 200-01
// Due:       1/27/2012
// By:        Jeremy Brown
// Purpose:   This class purpose to to track each patron's 
//            name and ID who has checked out a book.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryPatron
{
    private String patronName; // Name of the patron
    private String patronID;   // ID of the patron

    // Precondition:  None
    // Postcondition: The patron has been initialized with the specified name
    //                and ID
    public LibraryPatron(String name, String id)
    {
        PatronName = name;
        PatronID = id;
    }

    public String PatronName
    {
        // Precondition:  None
        // Postcondition: The patron's name has been returned
        get
        {
            return patronName;
        }

        // Precondition:  None
        // Postcondition: The patron's name has been set to the specified value
        set
        {
            patronName = value;
        }
    }

    public String PatronID
    {
        // Precondition:  None
        // Postcondition: The patron's ID has been returned
        get
        {
            return patronID;
        }

        // Precondition:  None
        // Postcondition: The patron's ID has been set to the specified value
        set
        {
            patronID = value;
        }
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary patron's data on 1 line
    public override string ToString()
    {
        return String.Format("{0}\n\t\tand their Patron ID is {1}",
            PatronName, PatronID);
    }

}

