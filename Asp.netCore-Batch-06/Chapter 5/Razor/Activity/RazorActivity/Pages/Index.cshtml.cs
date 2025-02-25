// Pages/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorActivity;
using System;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    private static IndexModel _instance;
    private static readonly object _lockObject = new object();

    [BindProperty]
    public Person Input { get; set; }
    public static List<Person> Persons { get; set; } = new List<Person>();

    public IndexModel()
    {
        // Private constructor to prevent instantiation outside the class
    }

    public static IndexModel Instance
    {
        get
        {
            // Double-check locking to ensure thread safety
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new IndexModel();
                    }
                }
            }
            return _instance;
        }
    }

    public void OnGet()
    {
        // Initialize or load data if needed
    }

    public void OnPost()
    {
        if (ModelState.IsValid)
        {
            Persons.Add(Input);
            // Clear the input fields after submission
        }
    }
}
