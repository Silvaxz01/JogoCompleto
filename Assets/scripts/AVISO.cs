using System;
using System.Threading.Tasks;

class AVISO
{
    static async Task Main(string[] args)
    {
        // Cria uma inst�ncia do objeto
        var myObject = new MyClass();

        // Exibe uma mensagem indicando que o objeto foi criado
        Console.WriteLine("Objeto criado.");

        // Espera 10 segundos
        await Task.Delay(10000);

        // Destr�i o objeto
        myObject = null;

        // For�a a coleta de lixo (opcional, apenas para fins de exemplo)
        GC.Collect();
        GC.WaitForPendingFinalizers();

        // Exibe uma mensagem indicando que o objeto foi destru�do
        Console.WriteLine("Objeto destru�do.");
    }
}

class MyClass
{
    // Voc� pode adicionar propriedades e m�todos ao MyClass aqui
}
