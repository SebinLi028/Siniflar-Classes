#include<iostream>
using namespace std;
const float pi = 3.14159;

class sphere{
public:
	float r, x, y, z, area(), volume();
};

float sphere::volume() { return(r*r*r * 4 * pi / 3); }
float sphere::area() { return(r*r * 4 * pi); }

int main() {
	sphere s;

	float r, x, y, z;
	cout << "r > ";
	cin >> r;
	cout << "x > ";
	cin >> x;
	cout << "y > ";
	cin >> y;
	cout << "z > ";
	cin >> z;

	s.r = r;
	s.x = x;
	s.y = y;
	s.z = z;
	cout << "\nx = " << s.x << ", y = " << s.y << ", z = " << s.z
		<< ", r = " << s.r << endl << "Area = " << s.area() << endl
		<< "Volume = " << s.volume() << endl;
	system("PAUSE");
	return 0;
}
