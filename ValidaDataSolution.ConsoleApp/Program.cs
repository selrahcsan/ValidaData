


DateTime dataDigitada;
do
{
    Console.WriteLine("Digite a data a ser validada :(DD/MM/YYYY)");
    var dataTemp = Console.ReadLine();
    var dataEhValida = DateTime.TryParse(dataTemp, out dataDigitada);
    var dataAtual = DateTime.Now;
    switch (dataEhValida)
    {
        case false:
            Console.WriteLine("Formato da data é inválido!");
            break;
        case true:
            dataDigitada = Convert.ToDateTime(dataTemp);
            Console.WriteLine(dataAtual >= dataDigitada 
                ? "Data, não pode ser menor ou igual a data atual"
                : "A data é valida o/");
            break;
    }
} while (dataDigitada <= DateTime.Now);