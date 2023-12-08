using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Models.TreeDataGrid;
using Test1.Models;

namespace Test1.ViewModels;

public class MainWindowViewModel : BaseViewModel
{
    private int _counter;

    private ObservableCollection<Person> _people;

    
    public FlatTreeDataGridSource<Person> Source { get; }

    public MainWindowViewModel()
    {
        _people = new ObservableCollection<Person>(GenerateMockPeopleTable());
        Source = new FlatTreeDataGridSource<Person>(_people)
        {
            Columns =
            {
                new TextColumn<Person, string>("First Name", x => x.FirstName),
                new TextColumn<Person, string>("Last Name", x => x.LastName),
                new TextColumn<Person, int>("Age", x => x.Age),
            },
        };
    }

    private IEnumerable<Person> GenerateMockPeopleTable()
    {
        var defaultPeople = new List<Person>()
        {
            new Person()
            {
                FirstName = "Pat",
                LastName = "Smith"
            },
            new Person()
            {
                FirstName = "Jean",
                LastName = "Jones"
            },
            new Person()
            {
                FirstName = "Terry",
                LastName = "Johnson"
            }
        };

        return defaultPeople;
    }

    public void AddRandomPerson()
    {
        var person = new Person();
        person.FirstName = $"Person {_counter}";

        _people.Add(person);
        _counter++;
    }

    public void AddLongRandomPerson()
    {
        var person = new Person();
        person.FirstName =
            @"Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of " +
            "This book is a treatise on the theory of ethics, " +
            "very popular during the Renaissance. The first line of Lorem Ipsum,";

        _people.Add(person);
        _counter++;
    }
}