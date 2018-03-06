#include <bits/stdc++.h>
using namespace std;
int main()
{
	long long n;
	long long s1, s2;
	cin >> n;
	s1 = 1;
	s2 = 1;
	long long fibo;
	for(int i = 2; i <= 46; i++)
	{
		fibo = s1 + s2;
		if(fibo == n)
		{
			cout<<"1"<<endl<<i+1;
			return 0;
		}
		s1 = s2;
		s2 = fibo;
	}
	cout<<"0";
	return 0;
}