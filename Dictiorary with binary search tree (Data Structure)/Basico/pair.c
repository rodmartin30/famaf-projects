#include <assert.h>
#include <stdlib.h>

#include "data.h"
#include "index.h"
#include "pair.h"

struct _pair_t {
    index_t first;
    data_t second;
};

pair_t pair_from_index_data(index_t index, data_t data) {

    assert(index != NULL && data != NULL);

    pair_t result = NULL;

    result = calloc(1, sizeof(struct _pair_t));
    assert(result != NULL);

    result->first = index;
    result->second = data;

    assert(result != NULL && index_is_equal(result->first, index)
           && data_is_equal(result->second, data));

    return result;
}

pair_t pair_destroy(pair_t pair) {

    pair->first = index_destroy(pair->first);
    pair->second = data_destroy(pair->second);

    free(pair);
    pair = NULL;

    return (pair);
}

index_t pair_fst(pair_t pair) {

    assert(pair != NULL);

    assert(pair->first != NULL);

    return (pair->first);
}

data_t pair_snd(pair_t pair) {

    assert(pair != NULL);

    assert(pair->second != NULL);

    return (pair->second);
}

bool pair_is_equal(pair_t pair, pair_t other) {

    assert(pair != NULL && other != NULL);

    return index_is_equal(pair->first, other->first)
        && data_is_equal(pair->second, other->second);
}

pair_t pair_copy(pair_t pair) {

    assert(pair != NULL);

    pair_t result = NULL;

    result =
        pair_from_index_data(index_copy(pair->first), data_copy(pair->second));

    assert(result != NULL && pair_is_equal(pair, result));
    return (result);

}
