// See https://aka.ms/new-console-template for more information

using DemoLibrary;

IPerson owner = Factory.CreatePerson();
owner.FirstName = "Januarius";
owner.LastName = "Njoku";
owner.EmailAddress = "njoku@gmail.com";
owner.PhoneNumber = "9992291";



IChore chore = Factory.CreateChore();
chore.ChoreName = "Take out the trash";
chore.Owner = owner;


chore.PerformedChore(4);
chore.PerformedChore(2);
chore.CompleteChore();

Console.ReadLine();
