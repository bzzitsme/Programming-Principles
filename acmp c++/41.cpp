#include <iostream>
#include <bits/stdc++.h>
void quicksort(int v, int left, int right)
{
	int pivot;
	int l_hold = left;
	int r_hold = right;
	pivot = v[left];
	while(left < right)
	{
		while((v[right] >= pivot) and (left < right))
			right--;
		if(left != right)
		{
			v[left] = v[right];
			left++;
		}
		while((v[left] <= pivot) and (left < right))
			left++;
		if (left != right)
		{
			v[right] = v[left];
			right--;
		}
	}
	v[left] = pivot;
	pivot = left;
	left = l_hold;
	right = r_hold;
	if(left < pivot)
		quicksort(v, left, pivot - 1)
	if(right > pivot)
		quicksort(v, pivot + 1, right);
}
using namespace std;
int main()
{
	int n;
	cin >> n;
	int a[n];
	int x;
	for(int i = 0;  i < n; i++)
	{
		cin >> a[i];
	}
	int p = a.size() - 1;
	quicksort(a, 0, p);
	for(int i = 0; i < p; i++)
	{
		cout<<a[i]<<" ";
	}
}