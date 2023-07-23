// See https://aka.ms/new-console-template for more information
void accept_input(string answer)
{
	Console.WriteLine(answer);
}

void ask_input()
{
	Console.WriteLine("Please give us your age");
	string input = Console.ReadLine();
	accept_input(input);
}

ask_input();
