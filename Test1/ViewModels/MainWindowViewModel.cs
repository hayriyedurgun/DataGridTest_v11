using System.Collections.Generic;
using System.Collections.ObjectModel;
using Test1.Models;

namespace Test1.ViewModels;

public class MainWindowViewModel: BaseViewModel
{
    private int _counter;
    
    private ObservableCollection<Person> _people;
    
    public ObservableCollection<Person> People
    {
        get => _people;
        private set
        {
            _people = value;
        }
    }
    
    public MainWindowViewModel()
    {
        People = new ObservableCollection<Person>(GenerateMockPeopleTable());
    }
    
    private IEnumerable<Person> GenerateMockPeopleTable()
    {
        var defaultPeople = new List<Person>()
        {
            new Person()
            {
                FirstName = "Pat", 
            },
            new Person()
            {
                FirstName = "Jean", 
            },
            new Person()
            {
                FirstName = "Terry", 
            }
        };
    
        return defaultPeople;
    }
    
    public void AddRandomPerson()
    {
        var person = new Person();
        person.FirstName = $"Person {_counter}";
        
        People.Add(person);
        _counter++;
    }
    
    public void AddLongRandomPerson()
    {
        var person = new Person();
        person.FirstName = @"Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of "+
                           "This book is a treatise on the theory of ethics, " +
                           "very popular during the Renaissance. The first line of Lorem Ipsum,";
        
        People.Add(person);
        _counter++;
    }
}