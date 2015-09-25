#include <assert.h>
#include <stdbool.h>
#include <stdlib.h>
#include "array_helpers.h"
#include "sort.h"

bool array_is_sorted(int *a, unsigned int length) {
    /* Needs implementation */
}

void swap(int *a, unsigned int i, unsigned int j) {
/*
    Swap the value at position 'i' with the value at position 'j' in the
    array 'a'. The values 'i' and 'j' must be valid positions in the array.

*/
}

unsigned int min_pos_from(int *a, unsigned int length, unsigned int i) {
/*
    Return the position of the minimum value in the array 'a' starting
    at position 'i'. The array 'a' must have exactly 'length' elements,
    and 'i' must be a valid position in the array.

*/
}

void selection_sort(int *a, unsigned int length) {
    assert(array_is_valid(a, length));

    /* Needs implementation */

    /* Check postconditions */
    assert(array_is_sorted(a, length));
}

void insertion_sort(int *a, unsigned int length) {
    assert(array_is_valid(a, length));

    /* Needs implementation */

    /* Check postconditions */
    assert(array_is_sorted(a, length));
}

void quick_sort(int *a, unsigned int length) {
    assert(array_is_valid(a, length));

    /* Needs implementation */

    /* Check postconditions */
    assert(array_is_sorted(a, length));
}
