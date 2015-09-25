#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include "array_helpers.h"
#include "sort.h"
#include <stdio.h>
bool array_is_sorted(int *a, unsigned int length) {
    bool flag = true; unsigned int i=1;
	while(i<length && flag){
		if(a[i-1]>a[i])
			flag = false;
		i++;
	}
			
	return flag;
}

void swap(int *a, unsigned int i, unsigned int j) {
	unsigned int temp = a[i];
	a[i] = a[j];
	a[j] = temp;
}

unsigned int min_pos_from(int *a, unsigned int length, unsigned int i) {
	unsigned int k,min = i;
	for(k=i;k<length;k++)
		if(a[k]<a[min])
			min = k;
	return min;
}

void selection_sort(int *a, unsigned int length) {
    assert(array_is_valid(a, length));

    unsigned int i,min=0;
	for(i=0;i<length;i++)
	{
		min = min_pos_from(a,length,i);
		swap(a,i,min);
	}

    /* Check postconditions */
    assert(array_is_sorted(a, length));
}

void insertion_sort(int *a, unsigned int length) {
    assert(array_is_valid(a, length));
	unsigned int i,j;
	for(i =0;i<length;i++)
	{
		j=i;
		while(j>0 && a[j]<a[j-1])
		{
			swap(a,j,j-1);
			j--;
		}
		
	}
    /* Check postconditions */
    assert(array_is_sorted(a, length));
}



unsigned int pivot(int*a, unsigned int izq, unsigned int der) {
	unsigned int n, m, piv;
	piv = izq;
	n = izq + 1;
	m = der;
	while (n<=m) {
	    if (a[n] <= a[piv]) {
			n++;
	    }
	    else if (a[m] > a[piv]) {
			m--;
	    }
	    else if (a[n] > a[piv] && a[m] <= a[piv]) {
			swap(a,n,m);
			n++;
			m--;
	    }
	}
	swap(a,piv,m);
	piv = m;
	return piv;
}


void quick_sort_count(int *a, unsigned int length, unsigned int izq, unsigned int der) {
	unsigned int piv;
	if (der<length && der > izq) {
		piv = pivot(a, izq, der);
		quick_sort_count(a,length,izq,piv-1);
		quick_sort_count(a,length,piv+1,der);
	}
}


void quick_sort(int *a, unsigned int length) {
    assert(array_is_valid(a, length));
	quick_sort_count(a,length,0,length-1);

    /* Check postconditions */
    assert(array_is_sorted(a, length));
}
