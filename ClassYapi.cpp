#include<iostream>
using namespace std;

class person{
public:
	char name[20];
	int number;
};

int main() {
	person obj;
	cout << "Enter the Name: ";
	cin >> obj.name;
	cout << "Enter the Number: ";
	cin >> obj.number;
	cout << obj.name << " : " << obj.number << endl;
	system("Pause");
	return 0;
}
