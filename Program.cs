Console.Clear();
Console.WriteLine("--- Esperto Contra Sabido ---\n");

int total = 0; 
bool ok = false; 

while (!ok)
{
    Console.Write("Quantos alimentos serão distribuídos? ");
    
    string tempInput = Console.ReadLine(); 
    string input = string.Empty;

    if (tempInput != null)
    {
        input = tempInput;
    }
    
    if (input.Length > 0)
    {
        if (int.TryParse(input, out total))
        {
            if (total > 0)
            {
                ok = true;
            }
        }
    }
    
    if (!ok)
    {
        Console.Clear();
        Console.WriteLine("                --- Erro!!! --- ");
        Console.WriteLine("\nPor favor, digite um número inteiro positivo válido.");
        Thread.Sleep(1500);
        //Console.ReadKey(); 
        Console.Clear();
        Console.WriteLine("--- Esperto Contra Sabido ---\n"); 
    }
}

Console.WriteLine();

int resta = total;     
int picaPau = 0;       
int raposinha = 0;     

int rodada = 0;        
int contaMim = 0;     
while (resta > 0)
{
    rodada++;          
    picaPau += 1;      
    resta -= 1;        
    Console.Write($"{rodada} para você. "); 
    if (resta <= 0)
    {
        Console.WriteLine(); 
        break;
    }

    contaMim = 0;
    
    while (resta > 0 && contaMim < rodada)
    {
        contaMim++;
        raposinha += 1;
        resta -= 1;

        Console.Write($"{contaMim}"); 
        if (contaMim < rodada && resta > 0)
        {
            Console.Write(", "); 
        }
        else
        {
             Console.Write(" "); 
        }
    }
    
    if (contaMim > 0)
    {
        Console.WriteLine("para mim.");
    }
}
Console.WriteLine();
Console.WriteLine("--- Resultado Final ---");
Console.WriteLine($"Pica-pau recebeu {picaPau} alimento(s).");
Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");
Console.WriteLine();
Console.WriteLine("Fim da distribuição.");