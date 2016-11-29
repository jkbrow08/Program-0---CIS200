// Assignment: Program 0
// Class:     CIS 200-01
// Due:       1/27/2012
// By:        Jeremy Brown
// Purpose:   This class purpose is to track the book's title,
//            author, publisher, copyright year, call number,
//            and checked out status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public const int DEFAULT_YEAR = 2011; // Default copyright year

    private String bookTitle;         // The book's title
    private String bookAuthor;        // The book's author
    private String bookPublisher;     // The book's publisher
    private int bookCopyrightYear;    // The book's year of copyright
    private String bookCallNumber;    // The book's call number in the library
    private bool bookCheckedOut;      // The book's checked out status
    private LibraryPatron patronInfo; // The book's patron info 
    private string checkOutStatus;    // The book's checked out status in 
                                      // custom string format

    // Precondition:  None
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber)
    {
        // Establish default first in case invalid
        CopyrightYear = DEFAULT_YEAR;

        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;

        ReturnToShelf(); // Make sure book is not checked out
    }

    public String Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return bookTitle;
        }

        // HELPER - not public
        // Precondition:  None
        // Postcondition: The title has been set to the specified value
        private set
        {
            bookTitle = value;
        }
    }

    public String Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return bookAuthor;
        }

        // HELPER - not public
        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        private set
        {
            bookAuthor = value;
        }
    }

    public String Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return bookPublisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            bookPublisher = value;
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return bookCopyrightYear;
        }

        // HELPER - not public
        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        private set
        {
            if (value >= 0)
                bookCopyrightYear = value;
        }
    }

    public String CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return bookCallNumber;
        }

        // Precondition:  None
        // Postcondition: The call number has been set to the specified value
        set
        {
            bookCallNumber = value;
        }
    }

    // Precondition:  None
    // Postcondition: The book is checked out and patron info is returned
    public void CheckOut(LibraryPatron p)
    {
        bookCheckedOut = true;
        patronInfo = p;

    }

    // Precondition:  None
    // Postcondition: The book is not checked out and patron info is cleared
    public void ReturnToShelf()
    {
        bookCheckedOut = false;
        patronInfo = null;
    }
    // Precondition:  Book must be checked out.
    // Postcondition: The patron's info is retruned.
    public LibraryPatron GetPatron()
    {
        IsCheckedOut();

        // If book is not checked out return null patron info,
        // else return patron info for book
        if (bookCheckedOut == false)
        {
            patronInfo = null;
            
        }
       return patronInfo;

    }
    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned

    public bool IsCheckedOut()
    {
        return bookCheckedOut;
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary book's data on
    //                separate lines
    public override string ToString()
    {
        //Determines if book is checked out and if it is display patron info
        if (IsCheckedOut())
        {
            checkOutStatus = string.Format("The book is currently checked out by {0}", GetPatron());
        }else checkOutStatus = "This book is currently not checked out";

        return String.Format("Title:\t\t{0}\nAuthor:\t\t{1}\nPublisher:\t{2}\n" +
            "Copyright:\t{3}\nCall Number:\t{4}\nChecked Out:\t{5}\nBook Status:\t{6}\n",
            Title, Author, Publisher, CopyrightYear, CallNumber, IsCheckedOut() , checkOutStatus);
    }
}
