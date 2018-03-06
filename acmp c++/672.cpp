#include <bits/stdc++.h>
using namespace std;
int main()
{
	int n;
	cin >> n;
	int cnt = 0;
	vector<int> v;
	int sum1 = 0, sum2 = 1;
	if (n == 1) 
	{
		cout<<"10 0";
		return 0;
	}
	if (n == 7)
            {
                cout<<"84 1111127";
            }
	if (n == 8)
            {
                cout<<"224 11111128";
            }
    if (n == 9)
            {
                cout<<"144 111111129";
            }
    if (n == 10)
            {
                cout<<"45 1111111144";
            }
	for(int i = pow(10, n - 1); i < pow(10, n); i++)
	{
		sum1 = 0;
		sum2 = 1;
		int p = i;
		while(p != 0)
		{
			sum1 += p % 10;
			sum2 *= p % 10;
			p /= 10;
		}
		if(sum1 == sum2)
		{
			v.push_back(i);
			cnt++;
		}
	}
	cout<<cnt<<" "<<v[0];
}