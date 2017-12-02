//Programmed in C++ 


#include <iostream>
using namespace std;

int main()
{

	int num;
	char selection = 'Y';

	do
	{

		cout << "Please enter an integer: ";

		while (!(cin >> num) || cin.get() != '\n')
		{
			cout << "That was not an integer! Please enter an integer: ";
			cin.clear();
			cin.ignore();
		}

		if (num % 2 == 0)
			cout << "\n\nYour integer is even.\n\n";
		else
			cout << "\n\nYour integer is odd.\n\n";

		cout << "Would you like to evaluate another integer? (any key to continue, Q to quit program)\n\n";
		cin >> selection;
		system("cls");

	} while (toupper(selection) != 'Q');

}
