#include <iostream>
#include <cmath>
using namespace std;
int main()
{
	int a, b;
	cin >> a >> b;
	for(int i = 1; i <= 1000; i++)
	{
		for(int j = 1; j <= 1000; j++)
		{
			if(i + j == a and i * j == b)
			{
				cout<<i<<" "<<j;
				return 0;
			}
		}
	}
}