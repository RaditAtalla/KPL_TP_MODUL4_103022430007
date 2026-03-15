DoorMachine.main();

public class DoorMachine
{
    enum State { Terkunci, Terbuka }

    public static void main()
    {
        State state = State.Terkunci;

        while (true)
        {
            if (state == State.Terkunci)
            {
                Console.WriteLine("Pintu Terkunci");
                state = State.Terbuka;

            }
            else if (state == State.Terbuka)
            {
                Console.WriteLine("Pintu tidak Terkunci");
                state = State.Terkunci;
            }

            Console.WriteLine("Plilih state: ");
            string input = Console.ReadLine();

            switch (state)
            {
                case State.Terkunci:
                    if (input == "buka")
                    {
                        state = State.Terbuka;
                    }
                    break;
                case State.Terbuka:
                    if (input == "kunci")
                    {
                        state = State.Terkunci;
                    }
                    break;
            }
        }
    }
}