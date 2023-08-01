
string name = "Seba";
string gender = "Male";
int age = 18;

if( gender == "Female" && age < 30 )
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if(gender == "Male" && age < 18 )
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if(name == "Ewa" && age == 33 )
{
    Console.WriteLine("Ewa lat 33" );
}
else
{
    Console.WriteLine("Parametry nie pasują do żadnych kategorii");
}