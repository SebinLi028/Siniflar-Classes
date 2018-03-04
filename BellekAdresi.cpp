#include<iostream>
#include<cstdlib>
#include<cstring>
using namespace std;

class infos
{
public:
	void hide(char *a, char *res);
	void show();
private:
	char name[20];
	char address[20];
};

void infos::hide(char *a, char *res)
{
	strcpy_s(name, a);
	strcpy_s(address, res);
}

void infos::show()
{
	cout << "Your Name: " << name << endl;
	cout << "Address: " << &address;
}

int main() 
{
	char name[20], *address;
	cout << "Enter Your Name: ";
	cin >> name;
	address = name;
	cout << endl << "Character Length: " << strlen(name) << endl;
	infos person1;
	person1.hide(name, address);
	person1.show();
	cout << endl << endl;
	system("PAUSE");
	return 0;
}
