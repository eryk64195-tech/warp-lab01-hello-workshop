/*Console.Write("Eryk ");
Console.WriteLine("Informatyka");
Console.WriteLine("Chcę się nauczyć programować");

Console.WriteLine("+----------------+");
Console.WriteLine("|   Wizytówka    |");
Console.WriteLine("+----------------+");
Console.WriteLine("| Imię: Eryk     |");
Console.WriteLine("| Wiek: 19       |");
Console.WriteLine("| Gra: Elden Rng |");
Console.WriteLine("+----------------+");

Console.Write("Jak masz na imię? ");
string imie = Console.ReadLine()!;
Console.Write("jaki jet twój ulubiony kolor? ");
string kolor = Console.ReadLine()!;
Console.WriteLine();
Console.WriteLine($"Cześć, {imie}! {kolor} to świetny kolor na płaszcz poszukiwacza przygód.");

Console.WriteLine("Ile masz lat? ");
int wiek = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Za rok będziesz miał {wiek + 1} a za pięć {wiek + 5}  ");

Console.WriteLine("Ile kilometrów zostało do celu? ");
int cel = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ile kilometrów pokonujesz każdego dnia? ");
int droga = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Zostało ci {cel/droga} km");

Console.WriteLine("Ile masz złotych monet? ");
int złoto = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ile masz srebrnych monet? ");
int srebro = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ile masz miedzianych monet? ");
int miedź = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Łączna wartość sakwy wyrażona w miedzianych monetach to {(złoto * 100)+(srebro * 10) + (miedź)}");

Console.WriteLine("Ile mikstur chcesz przygotować? ");
int mikstura = int.Parse(Console.ReadLine());
Console.WriteLine($"Będziesz potrzebować {mikstura * 3} kryształów oraz {mikstura * 2} ziół");

Console.WriteLine("Ile kosztuje nocleg ?");
decimal cena = decimal.Parse(Console.ReadLine());
Console.WriteLine("Na ile nocy zostajesz ?");
int noce = int.Parse(Console.ReadLine());
decimal koszt = cena * noce;
Console.WriteLine($"Koszt pobytu wnosi {koszt} zł");

int sekundy = int.Parse(Console.ReadLine());
int minuty = sekundy / 60;
int resztasekund = sekundy % 60;
Console.WriteLine($"{minuty} minuty i {resztasekund} sekundy");

Console.WriteLine("Ile monet zdobyła drużyna ?");
int monety = int.Parse(Console.ReadLine());
Console.WriteLine("Ile jest osób w drużynie ?");
int osoby = int.Parse(Console.ReadLine());
int pelnemonety = monety/osoby;
int resztamonet = monety % osoby;
Console.WriteLine($"Monet na osobe wynosi {pelnemonety} i zostaje {resztamonet} reszty");

Console.Write("Podaj obrażenia broni: ");
int wpdmg = int.Parse(Console.ReadLine()!);

Console.Write("Podaj premię do siły: ");
int premia = int.Parse(Console.ReadLine()!);

int podstawowy_atk = premia + wpdmg;
int atk_sp = podstawowy_atk * 2;
Console.WriteLine($"Twój podstawowy atak wynosi {podstawowy_atk}");
Console.WriteLine($"Twój atak specjalny wynosi {atk_sp}");
Console.WriteLine($"Twoje łączne obrażenia trzech zwykłych ataków i jednego specjalnego wynoszą: {podstawowy_atk} + {podstawowy_atk} + {podstawowy_atk} + {atk_sp} = {(podstawowy_atk *3)+(atk_sp)}");
*/
Console.WriteLine("Podaj imię bohater: ");
string name = Console.ReadLine();
Console.WriteLine("Podaj nazwę krainy: ");
string kraina = Console.ReadLine();
Console.WriteLine("Liczbę dni wyprawy: ");
int dni = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ilość zdobytego doświadczenia: ");
int exp = int.Parse(Console.ReadLine());
Console.WriteLine("Ilość zdobytego złota: ");
int gold = int.Parse(Console.ReadLine());
double expd = (double)exp/dni;
double goldd = (double)gold/dni;
Console.WriteLine();
Console.WriteLine("----Dziennik----");
Console.WriteLine($"Bohater: {name}");
Console.WriteLine($"Kraj: {kraina}");
Console.WriteLine($"ilość dni: {dni}");
Console.WriteLine($"zdobyte doświadczenie: {exp}");
Console.WriteLine($"zdobyte złoto: {gold}");
Console.WriteLine($"Doświadczenie na dzień: {expd}");
Console.WriteLine($"złoto na dzień: {goldd}");
