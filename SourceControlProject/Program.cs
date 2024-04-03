// See https://aka.ms/new-console-template for more information
using SourceControlProject;
using SourceControlProject.Memento;

Console.WriteLine("Hello, World!");
//MyFile f = new("fd", "fdgkdjhgdhitr");
Repository r = new("I'm a project");
Branch b1 = new("server");
Branch b2 = new("client");
Branch b3 = new("new feature");

r.AddBranch(b1);
r.AddBranch(b2);
r.AddBranch(b3);

r.GetBranch("server");
r.CreateBranch("client", "New Client Feature");


b1.Add(new Folder("client"));
b1.Add(new MyFile("Client", "public void client(){}"));




b1.commit(); //cannot commit yet

b1.Add();
Console.WriteLine(b1.state.getStatus());
b1.commit();

b1.RequestAReview();
Console.WriteLine(b1.state.getStatus());
b2.Marge(b1);

Caretaker caretaker = new Caretaker (b1);
caretaker.Backup();
caretaker.Undo();
caretaker.ShowHistory();
caretaker.Backup();
caretaker.Undo();