using System.Text;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// shift constant for Caesar chiffer
const int SHIFT = 3;

// root endpoint
app.MapGet("/", () => "Kryptering och avkryptering av text API!");

// endpoint for encryption

// endpoint for decryption

app.Run();

// Metod för ceasar chiffer
string CaesarChiffer(string input, int shift)
{
    const string lower = "abcdefghijklmnopqrstuvwxyzåäö";
    const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
    const int n = 29; // antal bokstäver i det svenska alfabetet

    // skapar en string builder för att bygga den krypterade/avkrypterade strängen
    var sb = new StringBuilder(input.Length);

    foreach (char c in input)
    {
        int i = lower.IndexOf(c);

        // kollar om tecknet är en liten bokstav
        if (i >= 0)
        {
            sb.Append(lower[(i + shift + n) % n]);
            continue;
        }

        i = upper.IndexOf(c);

        // kollar om tecknet är en stor bokstav
        if (i >= 0)
        {
            sb.Append(upper[(i + shift + n) % n]);
            continue;
        }
        // om tecknet inte är en bokstav, lägg till det oförändrat
        sb.Append(c);
    }
    // returnerar den krypterade/avkrypterade strängen
    return sb.ToString();
}