Theatre theatre = new Theatre();
try
{
    Console.Write("Введите название спектакля: ");
    theatre.Name = Console.ReadLine();
    Console.Write("Введите кол-во зрителей в начале: ");
    theatre.AudienceStart = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите кол-во зрителей в конце: ");
    theatre.AudienceEnd = Convert.ToDouble(Console.ReadLine());
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}
Console.WriteLine($"Спектакль: {theatre.Name} | Q = {theatre.Q():F2}");

SecTheatre secTheatre = new SecTheatre();

try
{
    Console.Write("Введите название спектакля: ");
    secTheatre.Name = Console.ReadLine();
    Console.Write("Введите кол-во зрителей в начале: ");
    secTheatre.AudienceStart = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите кол-во зрителей в конце: ");
    secTheatre.AudienceEnd = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите год написания пьесы: ");
    secTheatre.P = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите текущий год: ");
    secTheatre.T = Convert.ToDouble(Console.ReadLine());
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}
Console.WriteLine($"Спектакль: {secTheatre.Name} | Q = {secTheatre.Q():F2}");
public class Theatre
{
    public string? Name { get; set; }
    public double AudienceStart { get; set; }
    public double AudienceEnd { get; set; }
    public Theatre(string? name, double audienceStart, double audienceEnd)
    {
        Name = name;
        AudienceStart = AudienceStart;
        AudienceEnd = AudienceEnd;
    }
    public Theatre()
    {
        Name = "";
        AudienceStart = 0;
        AudienceEnd = 0;
    }
    public double Q()
    {
        return (AudienceEnd + AudienceStart) / AudienceStart;
    }
}
public class SecTheatre : Theatre 
{
    public double P { get; set; }
    public double T { get; set; }

    public SecTheatre(string? name, double audienceStart, double audienceEnd, double p, double t)
        : base(name, audienceStart, audienceEnd)
    {
        P = p;
        T = t;
    }
    public SecTheatre()
    {
        P = 0;
        T = 0;
    }
    public new double Q()
    {
        return base.Q() * (T - P + 1);
    }
}