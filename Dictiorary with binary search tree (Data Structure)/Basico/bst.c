/**************************************
* Authors: Morales, Marianela.        *
*          Rodriguez, Martin.         *
* Date of the last update: 05/05/2015 *
*                                     *
**************************************/

#include <assert.h>
#include <stdlib.h>
#include <stdbool.h>

#include "bst.h"
#include "data.h"
#include "index.h"
#include "list.h"
#include "pair.h"


struct _tree_node_t {
    pair_t pair;
    bst_t left;
    bst_t right;
};

bst_t bst_empty(void) {
    bst_t bst = NULL;
    return (bst);
}

bst_t bst_destroy(bst_t bst) {
    /* To destroy the current node, first we need to destroy its pair,
     * and its children if it have */
    if (bst != NULL) {
        bst->pair = pair_destroy(bst->pair);
        if (bst->left != NULL) {
            bst->left = bst_destroy(bst->left);
        }
        if (bst->right != NULL) {
            bst->right = bst_destroy(bst->right);
        }

        /* Free the allocated resources */
        free(bst);
    }
    bst = NULL;
    return (bst);
}

unsigned int bst_length(bst_t bst) {
    unsigned int length;
    length = 0;

    if (bst != NULL) {
        /* For the current node we increase length by one and then we plus the 
         * length of its childrens */
        ++length;
        length += bst_length(bst->left);
        length += bst_length(bst->right);
    }
    return (length);
}

bool bst_is_equal(bst_t bst, bst_t other) {
    bool result = true;
    /* */
    if (bst != NULL && other != NULL) {
        result = pair_is_equal(bst->pair, other->pair);
        if (result) {
            result = bst_is_equal(bst->left, other->left);
        }
        if (result) {
            result = bst_is_equal(bst->right, other->right);
        }
    } else if (bst != NULL || other != NULL) {
        result = false;
    }
    return (result);
}

data_t bst_search(bst_t bst, index_t index) {
    data_t data = NULL;
    if (bst != NULL) {
        if (index_is_equal(index, pair_fst(bst->pair))) {
            data = pair_snd(bst->pair);
        } else {
            if (index_is_less_than(index, pair_fst(bst->pair))) {
                data = bst_search(bst->left, index);
            } else {
                data = bst_search(bst->right, index);
            }
        }
    }
    return (data);
}

bst_t bst_add(bst_t bst, index_t index, data_t data) {
    unsigned int prev_length = bst_length(bst);
    if (bst != NULL) {
        if (index_is_less_than(index, pair_fst(bst->pair))) {
            bst->left = bst_add(bst->left, index, data);
        } else if (!index_is_equal(index, pair_fst(bst->pair))){
            bst->right = bst_add(bst->right, index, data);
        }
    } else {
        bst_t add = calloc(1, sizeof(struct _tree_node_t));
        add->pair = pair_from_index_data(index, data);
        add->left = NULL;
        add->right = NULL;
        bst = add;
    }

    assert(prev_length + 1 == bst_length(bst));
    return bst;


}


pair_t bst_max(bst_t bst) {
    pair_t result = NULL;

    if (bst != NULL) {
        if (bst->right == NULL) {
            result = pair_copy(bst->pair);
        } else {
            result = bst_max(bst->right);
        }
    }

    return (result);
}

bst_t delete_max(bst_t bst) {
    bst_t current;
    if (bst != NULL) {
        if (bst->right == NULL) {
            current = bst->left;
            /* Free the allocated resources */
            bst->pair = pair_destroy(bst->pair);
            free(bst);
            bst = current;
        } else {
            bst->right = delete_max(bst->right);
        }
    }

    return (bst);
}

bst_t bst_remove(bst_t bst, index_t index) {
    bst_t current;

    if (bst != NULL) {

        if (index_is_less_than(index, pair_fst(bst->pair))) {
            bst->left = bst_remove(bst->left, index);
        } else if (index_is_equal(pair_fst(bst->pair), index) &&
                   bst->left == NULL) {
            current = bst->right;
            bst->pair = pair_destroy(bst->pair);
            free(bst);
            bst = current;
        } else if (index_is_equal(pair_fst(bst->pair), index) &&
                   bst->left != NULL) {
            bst->pair = pair_destroy(bst->pair);
            bst->pair = bst_max(bst->left);
            bst->left = delete_max(bst->left);
        } else {
            bst->right = bst_remove(bst->right, index);
        }
    }
    return (bst);
}

bst_t bst_copy(bst_t bst) {
    bst_t result = bst_empty();
    if (bst != NULL) {
        result = bst_add(result, index_copy(pair_fst(bst->pair)),
                         data_copy(pair_snd(bst->pair)));
        result->right = bst_copy(bst->right);
        result->left = bst_copy(bst->left);
    }
    return result;
}

list_t bst_to_list(bst_t bst, list_t list) {
    if (bst != NULL) {
        index_t index = index_copy(pair_fst(bst->pair));
        data_t data = data_copy(pair_snd(bst->pair));

        if (bst->left != NULL) {
            list = bst_to_list(bst->left, list);
        }
        list = list_append(list, index, data);
        if (bst->right != NULL) {
            list = bst_to_list(bst->right, list);
        }

        index = NULL;
        data = NULL;
    }
    return (list);
}
