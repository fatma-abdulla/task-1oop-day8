using task_oop_day8.modele;

string name, major;
    int GBA;
student Student=new student();
Console.WriteLine("enter your name and major and GBA");
    name=Console.ReadLine();
major=Console.ReadLine();
GBA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Student.getStudent (name ,major,GBA));
