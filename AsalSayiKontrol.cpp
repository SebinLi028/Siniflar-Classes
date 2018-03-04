#include<iostream>
#include<conio.h>
using namespace std;

class prime
{
public:
	int a, k, i;
	prime(int x)
	{
		a = x;
	}

	void calculate()
	{
		k = 1;
		for (i = 2; i <= a / 2; i++) {
			if (a % 2 == 0)
			{
				k = 0;
				break;
			}
			else
			{
				k = 1;
			}
		}
	}

	void show()
	{
		if (k == 1) cout << "\n  " << a << " is Prime Number.";
		else cout << "\n  " << a << " isn't Prime Number.";
	}
};

int main(void) 
{
	int a;
	cout << "Enter the Number: ";
	cin >> a;
	prime obj(a);
	obj.calculate();
	obj.show();
	getch();
	return 0;
}
