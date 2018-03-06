#include <iostream>
#include <bits/stdc++.h>
#include <cmath>
using namespace std;

int main()
{
	string name;
	getline(cin, name);
	vector<string> alphabet(3);
	for(int i = 0; i < alphabet.size(); i++)
	{
		cin >> alphabet[i];
	}
	sort(alphabet.begin(), alphabet.end());
	cout<<name<<" :  ";
	for(int i = 0; i < alphabet.size(); i++)
	{
		if(i == 2)
		{
			cout << alphabet[i]; 
			return 0;
		}
		else cout<< alphabet[i] << ", ";
	}
}