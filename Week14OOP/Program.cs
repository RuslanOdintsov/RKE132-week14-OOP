
Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

//myDog._name = "Don";
////myDog._breed = "American pitbull terrier";
//myDog._levelOfHappiness = 10;

Dog neighboursDog = new Dog("Good girl");
//neighboursDog._name = "Taro";
////neighboursDog._breed = "Chihuahua";
//neighboursDog._levelOfHappiness = 9;

Console.WriteLine($"My dog name is {myDog.Name} and my neighbour dog name is {neighboursDog.Name}");
//Console.WriteLine($"My dog is {myDog._breed} and my neighbour dog is {neighboursDog._breed}");
//Console.WriteLine($"My dog level of happiness is {myDog._levelOfHappiness}, and my neighbour dog level of happinness is {neighboursDog._levelOfHappiness}");

myDog.Rename("Bad Boy");
while (myDog.LevelOfHappinness != 5)
{
    myDog.Bark();
}
myDog.WagTail();
//Console.WriteLine($"Level of happiness: {myDog.LevelOfHappinness}");
//myDog.Bark();
//Console.WriteLine($"Level of happiness: {myDog.LevelOfHappinness}");

class Dog
{
    private string _name; //field
    //public string _breed;
    private int _levelOfHappiness = 0;

    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }
    //getter
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHappinness
    {
        get { return _levelOfHappiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("Woof-woof");
        _levelOfHappiness++;
    }
    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");
    }
}
