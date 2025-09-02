using System.Collections;
using System;
internal class Program
{
    static Stack<int> pilaOrigen = [];
    static Stack<int> pilaDestino = [];
    static Stack<int> pilaAuxiliar = [];
    static int pilaOrigenSeleccionada = 0;
    static int pilaDestinoSeleccionada = 0;

    private static void Main(string[] args)
    {
        for (int i = 7; i > 0; i--)
        {
            pilaOrigen.Push(i);
        }
        while (ComprobarOrdenPilaDestino(pilaDestino))
        {
            PintarMatrices();

            Console.WriteLine("Presione el numero de la pila origen (1=origen, 2=auxiliar, 3=destino)");
            int.TryParse(Console.ReadLine(), out pilaOrigenSeleccionada);

            if (!ValidarSiHayElementos(pilaOrigenSeleccionada))
                return;

            Console.WriteLine("Presione el numero de la pila destino (1=origen, 2=auxiliar, 3=destino)");
            int.TryParse(Console.ReadLine(), out pilaDestinoSeleccionada);

            if (EstaLlena(pilaDestinoSeleccionada))
                return;

            if (MovimientoValido(pilaOrigenSeleccionada, pilaDestinoSeleccionada))
            {
                Mover(pilaOrigenSeleccionada, pilaDestinoSeleccionada);
            }

        }


    }

    private static void PintarMatrices()
    {
        foreach (var item in pilaOrigen)
        {
            Console.WriteLine(item.ToString());
        }

        foreach (var item in pilaAuxiliar)
        {
            Console.WriteLine(item.ToString());
        }

        foreach (var item in pilaDestino)
        {
            Console.WriteLine(item.ToString());
        }
    }
    private static bool MovimientoValido(int origen, int destino)
    {
        if (origen == destino)
            return false;

        switch (origen)
        {

            case 1:
                switch (destino)
                {
                    // 1 => 2
                    case 2:
                        if (!pilaAuxiliar.Any())
                            return true;


                        return pilaOrigen.Peek() < pilaAuxiliar.Peek();
                    case 3:
                        if (!pilaDestino.Any())
                            return true;

                        return pilaOrigen.Peek() < pilaDestino.Peek();
                }
                break;
            case 2:
                switch (destino)
                {
                    case 1:
                        if (!pilaOrigen.Any())
                            return true;
                        return pilaAuxiliar.Peek() < pilaOrigen.Peek();
                    case 3:
                        if (!pilaDestino.Any())
                            return true;

                        return pilaAuxiliar.Peek() > pilaDestino.Peek();
                }
                break;
            case 3:
                switch (destino)
                {
                    case 1:
                        if (!pilaOrigen.Any())
                            return true;

                        return pilaDestino.Peek() < pilaOrigen.Peek();
                    case 2:
                        if (!pilaAuxiliar.Any())
                            return true;

                        return pilaDestino.Peek() < pilaAuxiliar.Peek();
                }
                break;


        }
        return false;
    }

    private static void Mover(int origen, int destino)
    {
        try
        {
            
            if (origen == destino)
                return;

            switch (origen)
            {

                case 1:
                    int valor1 = pilaOrigen.Peek();
                    switch (destino)
                    {

                        // 1 => 2
                        case 2:
                            if (EstaLlena(destino))
                                return;

                            pilaOrigen.Pop();
                            pilaAuxiliar.Push(valor1);
                            break;
                        case 3:
                            if (EstaLlena(destino))
                                return;

                            pilaOrigen.Pop();
                            pilaDestino.Push(valor1);
                            break;

                    }
                    break;
                case 2:
                    int valor2 = pilaAuxiliar.Peek();
                    switch (destino)
                    {
                        case 1:
                            if (EstaLlena(destino))
                                return;

                            pilaAuxiliar.Pop();
                            pilaOrigen.Push(valor2);
                            break;
                        case 3:
                            if (EstaLlena(destino))
                                return;

                            pilaAuxiliar.Pop();
                            pilaDestino.Push(valor2);
                            break;
                    }
                    break;
                case 3:
                    int valor3 = pilaDestino.Peek();
                    switch (destino)
                    {
                        case 1:
                            if (EstaLlena(destino))
                                return;

                            pilaDestino.Pop();
                            pilaOrigen.Push(valor3);

                            break;
                        case 2:
                            if (EstaLlena(destino))
                                return;

                            pilaDestino.Pop();
                            pilaAuxiliar.Push(valor3);
                            break;
                    }
                    break;


            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    private static bool EstaLlena(int pila = 1)
    {
        switch (pila)
        {
            case 1:
                return pilaOrigen.Count == 7;
            case 2:
                return pilaAuxiliar.Count == 7;

            case 3:
                return pilaDestino.Count == 7;
        }
        return false;
    }

    private static bool ValidarSiHayElementos(int pila = 1)
    {

        switch (pila)
        {
            case 1:
                return pilaOrigen.Any();
            case 2:
                return pilaAuxiliar.Any();

            case 3:
                return pilaDestino.Any();
        }
        return false;
    }

    private static bool ComprobarOrdenPilaDestino(Stack<int> pilaDestino)
    {
        int acarreo = 7;
        foreach (var i in pilaDestino)
        {
            if (i != acarreo)
                return false;

        }
        return true;
    }
}