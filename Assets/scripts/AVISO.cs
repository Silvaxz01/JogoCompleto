using System;
using System.Threading.Tasks;

class AVISO
{
    static async Task Main(string[] args)
    {
        // Cria uma instância do objeto
        var myObject = new MyClass();

        // Exibe uma mensagem indicando que o objeto foi criado
        Console.WriteLine("Objeto criado.");

        // Espera 10 segundos
        await Task.Delay(10000);

        // Destrói o objeto
        myObject = null;

        // Força a coleta de lixo (opcional, apenas para fins de exemplo)
        GC.Collect();
        GC.WaitForPendingFinalizers();

        // Exibe uma mensagem indicando que o objeto foi destruído
        Console.WriteLine("Objeto destruído.");
    }
}

class MyClass
{
    // Você pode adicionar propriedades e métodos ao MyClass aqui
}
