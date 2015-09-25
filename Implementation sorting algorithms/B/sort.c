#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include "array_helpers.h"
#include "sort.h"
#include <stdio.h>

struct sorting_stats_helper {
    unsigned int helper;
    unsigned long int comps;
    unsigned long int swaps;
};

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

struct sorting_stats_helper min_pos_from(int *a, unsigned int length, unsigned int i) {
	struct sorting_stats_helper result;
	result.comps=0;
	result.swaps=0;
	unsigned int min = i;
	unsigned int k;
	for(k=i;k<length;k++){
		if(a[k]<a[min])
			min = k;
		result.comps++;
	}
	result.helper = min;
	return result;
}

struct sorting_stats selection_sort(int *a, unsigned int length) {
    assert(array_is_valid(a, length));
    
	struct sorting_stats result;
	struct sorting_stats_helper minPosFrom;
	result.comps=0;
	result.swaps=0;
    unsigned int i;
	for(i=0;i<length;i++)
	{
		minPosFrom = min_pos_from(a,length,i);
		swap(a,i,minPosFrom.helper);
		result.swaps++;
		result.comps+= minPosFrom.comps;
	}

    /* Check postconditions */
    assert(array_is_sorted(a, length));
    return result;
}

struct sorting_stats insertion_sort(int *a, unsigned int length) {
    assert(array_is_valid(a, length));
    struct sorting_stats result;
	result.comps=0;
	result.swaps=0;
	unsigned int i,j;
	for(i =0;i<length;i++)
	{
		j=i;
		while(j>0 && a[j]<a[j-1])
		{
			swap(a,j,j-1);
			result.swaps++;
			result.comps+=2;
			j--;
		}
		result.comps+=2;
		
	}
    /* Check postconditions */
    assert(array_is_sorted(a, length));
    return result;
}



struct sorting_stats_helper pivot(int*a, unsigned int izq, unsigned int der) {
	struct sorting_stats_helper result;
	result.comps=0;
	result.swaps=0;
	unsigned int n, m, piv;
	piv = izq;
	n = izq + 1;
	m = der;
	while (n<=m) {
		result.comps++;
	    if (a[n] <= a[piv]) {
	    	result.comps++;
			n++;
	    }
	    else if (a[m] > a[piv]) {
	    	result.comps+=2;
			m--;
	    }
	    else if (a[n] > a[piv] && a[m] <= a[piv]) {
	    	result.comps+=4;
			swap(a,n,m);
			result.swaps++;
			n++;
			m--;
	    }
		result.comps++;
	    
	}
	swap(a,piv,m);
	result.swaps++;
	piv = m;
	result.helper = piv;
	return result;
}



struct sorting_stats quick_sort_count(int *a, unsigned int length, unsigned int izq, unsigned int der) {
	struct sorting_stats result,temp;
	struct sorting_stats_helper sPivot;
	result.comps=0;
	result.swaps=0;
	unsigned int piv;
	if (der<length && der > izq) {
		result.comps++;
		sPivot = pivot(a, izq, der);
		piv = sPivot.helper;
		result.comps+=sPivot.comps;
		result.swaps+=sPivot.swaps;
		temp = quick_sort_count(a,length,izq,piv-1);
		result.comps += temp.comps;
		result.swaps += temp.swaps;
		temp = quick_sort_count(a,length,piv+1,der);
		result.comps += temp.comps;
		result.swaps += temp.swaps;
	}
	result.comps++;
	return result;
}


struct sorting_stats quick_sort(int *a, unsigned int length) {
    assert(array_is_valid(a, length));
    struct sorting_stats result;
	result.comps=0;
	result.swaps=0;
	result = quick_sort_count(a,length,0,length-1);

    /* Check postconditions */
    assert(array_is_sorted(a, length));
    return result;
}
