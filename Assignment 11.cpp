#include <iostream>
using namespace std;

int gcdFinder(int num1, int num2);

int main()
{

	int num1;
	int num2;
	int gcd;
	char selection = 'Y';

	do
	{

		cout << "Please enter two integers to find greatest common divisor: ";

		while (!(cin >> num1) || cin.get() != '\n')
		{
			cout << "That was not an integer! Please enter an integer: ";
			cin.clear();
			cin.ignore();
		}
		while (!(cin >> num2) || cin.get() != '\n')
		{
			cout << "That was not an integer! Please enter an integer: ";
			cin.clear();
			cin.ignore();
		}

		gcd = gcdFinder(num1, num2);

		cout << "The GCD is " << gcd << "." << endl << endl;
		


		
		cout << "Would you like to evaluate another integer? (any key to continue, Q to quit program)\n\n";
		cin >> selection;
		system("cls");

	} while (toupper(selection) != 'Q');

}


int gcdFinder(int num1, int num2)
{
	int minNum;
	int gcd = 0;
	if (num1 <= num2)
	{
		minNum = num1;
	}
	else if (num1 > num2)
	{
		minNum = num2;
	}
	
	for (int i = 1; i <= minNum; i++)
	{
		if (num1%i == 0 && num2%i == 0)
			gcd = i;
	}
	

	return gcd;
}
