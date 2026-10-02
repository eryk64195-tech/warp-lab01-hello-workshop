
Console.Write("Podaj imię gracza: ");
string imie = Console.ReadLine();
Console.Write($"Podaj punkty życia: ");
int punktyZycia = int.Parse(Console.ReadLine());
Console.Write($"Podaj poziom siły: ");
int sila = int.Parse(Console.ReadLine());
Console.Write($"Podaj poziom doświadczenia: ");
int poziom = int.Parse(Console.ReadLine());
Console.Write($"Podaj ilość złota: ");
double zloto = double.Parse(Console.ReadLine());

int punktyAtaku = sila * 2;
Console.WriteLine($"╔══════════════════════════════════════╗");
Console.WriteLine($"║             DARK REALM               ║");
Console.WriteLine($"║           KARTA BOHATERA             ║");
Console.WriteLine($"╠══════════════════════════════════════╣");
Console.WriteLine($"║                                      ║");
Console.WriteLine($"║ Imię:         {imie,-23}║");
Console.WriteLine($"║ Poziom:       {poziom,-23}║");
Console.WriteLine($"║                                      ║");
Console.WriteLine($"║ Punkty życia: {punktyZycia,-23}║");
Console.WriteLine($"║ Siła:         {sila,-23}║");
Console.WriteLine($"║ Złoto:        {zloto,-23}║");
Console.WriteLine($"║                                      ║");
Console.WriteLine($"║ Punkty ataku: {punktyAtaku,-23}║");
Console.WriteLine($"╠══════════════════════════════════════╣");
Console.WriteLine($"║     Przygoda dopiero się zaczyna     ║");
Console.WriteLine($"╚══════════════════════════════════════╝");