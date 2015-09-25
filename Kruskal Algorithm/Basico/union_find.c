#include <assert.h>
#include <stdlib.h>
#include <stdbool.h>

#include "union_find.h"

struct _union_find_t {
    uint maxSize;
    int *trep;
};

union_find_t union_find_create(uint max_size) {
    union_find_t result = malloc(1 * sizeof(struct _union_find_t));
    result->maxSize = max_size;
    result->trep = malloc((max_size) * sizeof(int));

    for (unsigned int i = 0; i < max_size; i++) {
        result->trep[i] = -1;
    }
    return result;
}

/* 
    Auxiliar function for union_find_find.
*/
bool is_rep(union_find_t uf, uint i) {
    return (uf->trep[i] < 0);
}

/*
    End of auxiliar function.
*/

uint union_find_find(union_find_t uf, uint elem) {
    assert(uf != NULL);
    assert(uf->trep != NULL);
    assert(elem < uf->maxSize);

    unsigned int result, j = elem, k;

    while (!is_rep(uf, j)) {
        j = uf->trep[j];
    }
    result = j;
    j = elem;
    while (!is_rep(uf, j)) {
        k = uf->trep[j];
        uf->trep[j] = result;
        j = k;
    }
    return result;
}

void union_find_union(union_find_t uf, uint elem1, uint elem2) {
    assert(is_rep(uf, elem1) && is_rep(uf, elem2));
    if (elem1 != elem2) {
        if (uf->trep[elem1] >= uf->trep[elem2]) {
            uf->trep[elem2] = uf->trep[elem1] + uf->trep[elem2];
            uf->trep[elem1] = elem2;
        } else if (uf->trep[elem1] < uf->trep[elem2]) {
            uf->trep[elem1] = uf->trep[elem2] + uf->trep[elem1];
            uf->trep[elem2] = elem1;
        }
    }
}

bool union_find_connected(union_find_t uf, uint elem1, uint elem2) {
    unsigned int i, j;
    i = union_find_find(uf, elem1);
    j = union_find_find(uf, elem2);

    return (i == j);
}

uint union_find_count(union_find_t uf) {
    uint count = 0;
    for (uint i = 0; i < uf->maxSize; i++)
        if (is_rep(uf, i))
            count++;
    return count;
}

union_find_t union_find_destroy(union_find_t uf) {
    free(uf->trep);
    free(uf);
    uf = NULL;

    return uf;
}
