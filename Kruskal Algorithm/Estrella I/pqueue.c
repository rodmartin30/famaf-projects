#include <assert.h>
#include <stdlib.h>
#include <stdbool.h>

#include "pqueue.h"

struct _pqueue_t {
    unsigned int size, maxSize;
    elem_t *elem;
};

/* Auxiliar function */

unsigned int left(unsigned int i) {
    return (2 * i + 1);
}

unsigned int right(unsigned int i) {
    return (2 * i + 2);
}

unsigned int parent(unsigned int i) {
    return ((i - 1) / 2);
}

bool has_children(pqueue_t pq, unsigned int i) {
    assert(i <= pq->size);
    return left(i) <= pq->size;
}

bool has_parent(unsigned int i) {
    return i != 0;
}

unsigned int min_child(pqueue_t pq, unsigned int i) {
    assert(i < pq->size && has_children(pq, i));
    unsigned int result;
    if (right(i) <= pq->size && elem_lt(pq->elem[right(i)], pq->elem[left(i)])) {
        result = right(i);
    } else {
        result = left(i);
    }
    return result;
}

void lift(pqueue_t pq, unsigned int i) {
    assert(i < pq->size && has_parent(i));
    elem_t tmp = pq->elem[i];
    pq->elem[i] = pq->elem[parent(i)];
    pq->elem[parent(i)] = tmp;

}

bool must_lift(pqueue_t pq, unsigned int i) {
    assert(i < pq->size);
    return elem_lt(pq->elem[i], pq->elem[parent(i)]);
}

void float_proc(pqueue_t pq) {
    unsigned int c = pq->size - 1;
    while (c < pq->size && has_parent(c) && must_lift(pq, c)) {
        lift(pq, c);
        c = parent(c);
    }
}

void sink(pqueue_t pq) {
    unsigned int p = 0;
    while (p < pq->size && has_children(pq, p) && min_child(pq, p) < pq->size
           && must_lift(pq, min_child(pq, p))) {
        p = min_child(pq, p);
        lift(pq, p);
    }
}

/* End of auxliar function */


pqueue_t pqueue_empty(unsigned int max_size) {
    pqueue_t result = calloc(1, sizeof(struct _pqueue_t));
    result->size = 0;
    result->maxSize = max_size;
    result->elem = calloc(max_size, sizeof(elem_t));

    return result;
}

bool pqueue_is_full(pqueue_t pq) {
    return pq->size == pq->maxSize;
}

bool pqueue_is_empty(pqueue_t pq) {
    return pq->size == 0;
}

elem_t pqueue_fst(pqueue_t pq) {
    assert(!pqueue_is_empty(pq));
    return pq->elem[0];
}

unsigned int pqueue_size(pqueue_t pq) {
    return pq->size;
}

void pqueue_enqueue(pqueue_t pq, elem_t elem) {
    assert(pq->size < pq->maxSize);
    pq->elem[pq->size] = elem;
    pq->size = pq->size + 1;
    float_proc(pq);
}

void pqueue_dequeue(pqueue_t pq) {
    assert(!pqueue_is_empty(pq));

    pq->elem[0] = elem_destroy(pq->elem[0]);
    pq->elem[0] = pq->elem[pq->size - 1];
    pq->size = pq->size - 1;
    sink(pq);
}

pqueue_t pqueue_destroy(pqueue_t pq) {
    assert(pq != NULL);
    for (unsigned int i = 0; i < pq->size; i++) {
        if (pq->elem[i] != NULL)
            pq->elem[i] = elem_destroy(pq->elem[i]);
    }
    free(pq->elem);
    free(pq);
    pq = NULL;
    return pq;
}
