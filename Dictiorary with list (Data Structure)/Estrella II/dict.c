#include "dict.h"
#include "list.h"
#include "data.h"
#include "index.h"
#include <stdlib.h>
#include <stdbool.h>
#include <assert.h>


struct _dict_t {
    unsigned int length;
    list_t list;
};

dict_t dict_empty(void) {
    dict_t dict = NULL;
    dict = calloc(1, sizeof(struct _dict_t));
    assert(dict != NULL);
    dict->length = 0;
    dict->list = list_empty();
    assert(dict != NULL && (dict->length == 0));
    return (dict);
}

/*
 * Return a newly created, empty dictionary.
 */

dict_t dict_destroy(dict_t dict) {
    dict->list = list_destroy(dict->list);
    free(dict);
    dict = NULL;
    return (dict);
}

/*
 * Free the resources allocated for the given 'dict', and set it to NULL.
 */

unsigned int dict_length(dict_t dict) {
    assert(dict != NULL);
    return (dict->length);
}

/*
 * Return the amount of elements in the given 'dict'.
 */

bool dict_is_equal(dict_t dict, dict_t other) {
    assert(dict != NULL && other != NULL);
    return (list_is_equal(dict->list, other->list) &&
            (dict->length == other->length));
}

/*
 * Return whether 'dict' is equal to 'other'.
 */

bool dict_exists(dict_t dict, word_t word) {
    assert(dict != NULL && word != NULL);
    bool result = false;
    index_t palabra = index_from_string(word);
    data_t definition = list_search(dict->list, palabra);
    if (definition != NULL)
        result = true;
    palabra = index_destroy(palabra);
    return (result);
}

/*
 * Return if the given 'word' exists in the dictionary 'dict'.
 */

def_t dict_search(dict_t dict, word_t word) {
    assert(dict != NULL && word != NULL && dict_exists(dict, word));
    index_t palabra = NULL;
    palabra = index_from_string(word);
    data_t definition = list_search(dict->list, palabra);
    def_t result = data_to_string(definition);
    palabra = index_destroy(palabra);
    assert(result != NULL);
    return (result);
}

/*
 * Return the definition associated with 'word'.
 */

dict_t dict_add(dict_t dict, word_t word, def_t def) {
    assert(dict != NULL && word != NULL && def != NULL &&
           (!dict_exists(dict, word)));
    index_t index_word = index_from_string(word);
    data_t data_def = data_from_string(def);
    list_t new_list = list_append(dict->list, index_word, data_def);
    dict->list = new_list;
    dict->length++;
    return (dict);
}

/*
 * Return the given 'dict' with the given ('word', 'def') added.
 */

dict_t dict_remove(dict_t dict, word_t word) {
    assert((dict != NULL) && (word != NULL) && (dict_exists(dict, word)));
    index_t index_word = index_from_string(word);
    list_t new_list = list_remove(dict->list, index_word);
    index_word = index_destroy(index_word);
    dict->list = new_list;
    dict->length--;
    return (dict);
}

/*
 * Return the given 'dict' with the given 'word' removed.
 */

dict_t dict_copy(dict_t dict) {
    dict_t dict_copy = calloc(1, sizeof(struct _dict_t));
    assert(dict_copy != NULL);
    dict_copy->length = dict->length;
    dict_copy->list = list_copy(dict->list);
    assert(dict_copy != NULL && dict_is_equal(dict_copy, dict));
    return (dict_copy);
}

/*
 * Return a newly created copy of the given 'dict'.
 */

void dict_dump(dict_t dict, FILE * fd) {
    assert(dict != NULL);
    list_dump(dict->list, fd);
}

/*
 * Dump the given 'dict' in the given file descriptor 'fd'.
 */
