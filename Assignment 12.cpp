#include <iostream>
using namespace std;

int gcdFinder(int num1, int num2);
int gcdEuclidian(int num1, int num2);

int main()
{

	int num1;
	int num2;
	int gcd;
	char selection = 'Y';
	char gcdMethod;

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
		
		cout << "would you like to find using euclidian method or brute force? (Enter E for euclidian or B for brute force)\n\n";
		cin >> gcdMethod;
		do
		{
			if (toupper(gcdMethod) != 'B' && toupper(gcdMethod) != 'E')
			{ 
				cout << "invalid entry, please enter your prefered method (Enter E for euclidian or B for brute force)\n\n";
				cin >> gcdMethod;
			}
			
		} while (toupper(gcdMethod) != 'B' && toupper(gcdMethod) != 'E');

		if (toupper(gcdMethod) == 'B')
			gcd = gcdFinder(num1, num2);
		if (toupper(gcdMethod) == 'E')
			gcd = gcdEuclidian(num1, num2);

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

int gcdEuclidian(int num1, int num2)
{
	//a is largest number, b is smallest number
	int a;
	int b;
	int r;
	if (num1 <= num2)
	{
		b = num1;
		a = num2;
	}
	else if (num1 > num2)
	{
		b = num2;
		a = num1;
	}

	//a=bq + r
	while (b != 0)
	{
		r = a % b;
		
		a = b;
		b = r;

		cout << ".";

		a = gcdEuclidian(a, b);
	} 

	return a;

}
